namespace Simple.Console
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This is a console application demonstrating simple access to the PLC variables in Inxton.Vortex.Framework.
    /// </summary>
    class Program
    {
        const string AmsId = "172.20.10.102.1.1";
        const int Port = 851;

        static void Main(string[] args)
        {

            // Creates an instance of HansPlc twin controller with TwinCat3 adapter.
            var hans = new HansPlc.HansPlcTwinController(Vortex.Adapters.Connector.Tc3.Adapter.Tc3ConnectorAdapter.Create(AmsId, Port));

            // This starts the operation on the TwinController. Without this call the twin controller instance is created but does not run the comm. operations.
            hans.Connector.BuildAndStart();


            // From this point on we have the TwinController up and running and we can access the PLC data.


            // To shorten the path to the variables we will place 'prgSimple' from hans Plc into simple variable.
            var simple = hans.prgSimple;


            /*
             
              This is the PLC code executed in the implementation block of prgSimple
              
               IF(_counterActive) THEN _counter := _counter + 1; END_IF
               IF(_reset) THEN _counter := 0; _reset := false; END_IF;
             */



            // Here we ask for _counter variable to be set to 0
            simple._reset.Synchron = true;

            // Here we ask _counter variable to be incremented by the PLC.
            simple._counterActive.Synchron = true;

            #region
            string command = string.Empty;
            uint cycleCount = 0;
            #endregion
            
            while(command.ToUpper() != "Q")
            {

                // Here we output the counter value to the console.
                System.Console.WriteLine($"Counter value : {simple._counter.Synchron}");


                // Each 10 cycles we ask to if you want to continue or quit the program.
                if((++cycleCount % 10) == 0)
                {
                    System.Console.WriteLine("Press enter to continue... or 'Q' to quit");
                    command = System.Console.ReadLine();
                }
            }
        }
    }
}
