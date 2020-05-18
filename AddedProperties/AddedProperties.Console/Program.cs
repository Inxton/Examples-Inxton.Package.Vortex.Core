using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vortex.Connector;

namespace AddedProperties.Console
{
    class Program
    {      
        static void Main(string[] args)
        {

            Hans.Connector.BuildAndStart();

            char command = '0';
            var obj = Hans.prgAddedProperties;

            obj.Read();

            while (command != 'Q')
            {                
                System.Console.WriteLine("************************************************************************");
                System.Console.WriteLine($"{obj.fbDriveX.Position.AttributeName}:{obj.fbDriveX.Position.Cyclic} {obj.fbDriveX.Position.AttributeUnits}");
                System.Console.WriteLine($"{obj.fbDriveX.Speed.AttributeName}:{obj.fbDriveX.Speed.Cyclic} {obj.fbDriveX.Speed.AttributeUnits}");
                System.Console.WriteLine($"{obj.fbDriveX.Acc.AttributeName}:{obj.fbDriveX.Acc.Cyclic} {obj.fbDriveX.Acc.AttributeUnits}");
                System.Console.WriteLine($"{obj.fbDriveX.Dcc.AttributeName}:{obj.fbDriveX.Dcc.Cyclic} {obj.fbDriveX.Dcc.AttributeUnits}");
                System.Console.WriteLine("************************************************************************");

                System.Console.WriteLine("Press any key to read again or 'Q' to terminate the program.");
                command = (char)System.Console.Read();                
            }
        }

        /// <summary>
        /// Gets TwinController of HansPlc.
        /// </summary>
        public static HansPlc.HansPlcTwinController Hans
        {
            get;
        } = HansPlc.Entry.HansPlc;
    }
}
