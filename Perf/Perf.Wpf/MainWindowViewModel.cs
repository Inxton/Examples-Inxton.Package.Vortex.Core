using HansPlc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vortex.Connector;


namespace Perf.Wpf
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {

        public MainWindowViewModel()
        {
            Entry.HansPlc.Connector.BuildAndStart().ReadWriteCycleDelay = 100000000;

            Console.WriteLine("Reading symbols...");
            // Force reading symbols
            Entry.HansPlc.prgPerf.Read();            

            System.Threading.Tasks.Task.Run(() => PerfReadCounters());
            // System.Threading.Tasks.Task.Run(() => PerfWriteCounters());            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void PerfReadCounters()
        {           
            var sw = new System.Diagnostics.Stopwatch();
            while (true)
            {
                ReadOps(sw);
                WriteOps(sw);
                System.Threading.Thread.Sleep(1);
            }

        }

        private void WriteOps(System.Diagnostics.Stopwatch sw)
        {
            if (DoWrite)
            {
                //Writing
                byte a = 0;
                foreach (var arr_item in Entry.HansPlc.prgPerf.hugeArrayOfPrimitive.arr_of_primitive.Take(NumberOfItemsToWrite))
                {
                    arr_item.Cyclic = a++;
                }

                sw.Restart();
                Entry.HansPlc.prgPerf.hugeArrayOfPrimitive.Write();
                sw.Stop();
                this.WriteArrayOfPrimitive = sw.ElapsedMilliseconds;

                a = 0;
                foreach (var arr_item in Entry.HansPlc.prgPerf.hugeArrayOfComplex.arr_of_complex.Take(NumberOfItemsToWrite))
                {
                    arr_item.BYTE_val.Cyclic = a++;
                    arr_item.INT_val.Cyclic = a++;
                    arr_item.STRING_val.Cyclic = $"hans{a}";
                }

                sw.Restart();
                Entry.HansPlc.prgPerf.hugeArrayOfComplex.Write();
                sw.Stop();
                this.WriteArrayOfCompex = sw.ElapsedMilliseconds;

                a = 0;
                foreach (var kid in Entry.HansPlc.prgPerf.hugeStructureOfPrimitive.GetKids().Take(NumberOfItemsToWrite))
                {
                    ((dynamic)kid).Cyclic = a++;
                }

                sw.Restart();
                Entry.HansPlc.prgPerf.hugeStructureOfPrimitive.Write();
                sw.Stop();
                this.WriteStructOfPrimitive = sw.ElapsedMilliseconds;

                a = 0;
                foreach (var structItem in Entry.HansPlc.prgPerf.hugeStructureOfComplex.GetKids().Take(NumberOfItemsToWrite).Where(p => p is stComplex).Select(p => p as stComplex))
                {
                    structItem.BYTE_val.Cyclic = a++;
                    structItem.INT_val.Cyclic = a++;
                    structItem.STRING_val.Cyclic = $"hans{a}";
                }

                sw.Restart();
                Entry.HansPlc.prgPerf.hugeStructureOfComplex.Write();
                sw.Stop();
                this.WriteStructureOfComplex = sw.ElapsedMilliseconds;

            }
        }

        private void ReadOps(System.Diagnostics.Stopwatch sw)
        {
            //Reading
            sw.Restart();
            Entry.HansPlc.prgPerf.hugeArrayOfPrimitive.Read();
            sw.Stop();
            this.ReadArrayOfPrimitive = sw.ElapsedMilliseconds;

            sw.Restart();
            Entry.HansPlc.prgPerf.hugeArrayOfComplex.Read();
            sw.Stop();
            this.ReadArrayOfCompex = sw.ElapsedMilliseconds;


            sw.Restart();
            Entry.HansPlc.prgPerf.hugeStructureOfPrimitive.Read();
            sw.Stop();
            this.ReadStructOfPrimitive = sw.ElapsedMilliseconds;

            sw.Restart();
            Entry.HansPlc.prgPerf.hugeStructureOfComplex.Read();
            sw.Stop();
            this.ReadStructureOfComplex = sw.ElapsedMilliseconds;
        }

        void PerfWriteCounters()
        {
            var sw = new System.Diagnostics.Stopwatch();
            while (true)
            {
                if (DoWrite)
                {
                    //Writing
                    byte a = 0;
                    foreach (var arr_item in Entry.HansPlc.prgPerf.hugeArrayOfPrimitive.arr_of_primitive.Take(NumberOfItemsToWrite))
                    {
                        arr_item.Cyclic = a++;
                    }

                    sw.Restart();
                    Entry.HansPlc.prgPerf.hugeArrayOfPrimitive.Write();
                    sw.Stop();
                    this.WriteArrayOfPrimitive = sw.ElapsedMilliseconds;

                    a = 0;
                    foreach (var arr_item in Entry.HansPlc.prgPerf.hugeArrayOfComplex.arr_of_complex.Take(NumberOfItemsToWrite))
                    {
                        arr_item.BYTE_val.Cyclic = a++;
                        arr_item.INT_val.Cyclic = a++;
                        arr_item.STRING_val.Cyclic = $"hans{a}";
                    }

                    sw.Restart();
                    Entry.HansPlc.prgPerf.hugeArrayOfComplex.Write();
                    sw.Stop();
                    this.WriteArrayOfCompex = sw.ElapsedMilliseconds;
                    
                    a = 0;
                    foreach (var kid in Entry.HansPlc.prgPerf.hugeStructureOfPrimitive.GetKids().Take(NumberOfItemsToWrite))
                    {
                        ((dynamic)kid).Cyclic = a++;
                    }

                    sw.Restart();
                    Entry.HansPlc.prgPerf.hugeStructureOfPrimitive.Write();
                    sw.Stop();
                    this.WriteStructOfPrimitive = sw.ElapsedMilliseconds;

                    a = 0;
                    foreach (var structItem in Entry.HansPlc.prgPerf.hugeStructureOfComplex.GetKids().Take(NumberOfItemsToWrite).Where(p => p is stComplex).Select(p => p as stComplex))
                    {
                        structItem.BYTE_val.Cyclic = a++;
                        structItem.INT_val.Cyclic = a++;
                        structItem.STRING_val.Cyclic = $"hans{a}";
                    }

                    sw.Restart();
                    Entry.HansPlc.prgPerf.hugeStructureOfComplex.Write();
                    sw.Stop();
                    this.WriteStructureOfComplex = sw.ElapsedMilliseconds;

                }

                System.Threading.Thread.Sleep(100);
            }

        }

        int numberOfItemsToWrite;
        public int NumberOfItemsToWrite
        {
            get => numberOfItemsToWrite; set
            {
                if (numberOfItemsToWrite == value)
                {
                    return;
                }

                numberOfItemsToWrite = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NumberOfItemsToWrite)));
            }
        }

        bool doWrite;
        public bool DoWrite
        {
            get => doWrite; set
            {
                if (doWrite == value)
                {
                    return;
                }

                doWrite = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DoWrite)));
            }
        }

        long readArrayOfPrimitive;
        public long ReadArrayOfPrimitive
        {
            get => readArrayOfPrimitive; set
            {
                if (readArrayOfPrimitive == value)
                {
                    return;
                }

                readArrayOfPrimitive = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ReadArrayOfPrimitive)));
            }
        }

        long readArrayOfCompex;
        public long ReadArrayOfCompex
        {
            get => readArrayOfCompex; set
            {
                if (readArrayOfCompex == value)
                {
                    return;
                }

                readArrayOfCompex = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ReadArrayOfCompex)));
            }
        }

        long readStructOfPrimitive;
        public long ReadStructOfPrimitive
        {
            get => readStructOfPrimitive; set
            {
                if (readStructOfPrimitive == value)
                {
                    return;
                }

                readStructOfPrimitive = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ReadStructOfPrimitive)));
            }
        }

        long readStructureOfComplex;
        public long ReadStructureOfComplex
        {
            get => readStructureOfComplex; set
            {
                if (readStructureOfComplex == value)
                {
                    return;
                }

                readStructureOfComplex = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ReadStructureOfComplex)));
            }
        }
        long writeArrayOfPrimitive;
        public long WriteArrayOfPrimitive
        {
            get => writeArrayOfPrimitive; set
            {
                if (writeArrayOfPrimitive == value)
                {
                    return;
                }

                writeArrayOfPrimitive = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(WriteArrayOfPrimitive)));
            }
        }
        long writeArrayOfCompex;
        public long WriteArrayOfCompex
        {
            get => writeArrayOfCompex; set
            {
                if (writeArrayOfCompex == value)
                {
                    return;
                }

                writeArrayOfCompex = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(WriteArrayOfCompex)));
            }
        }
        long writeStructOfPrimitive;
        public long WriteStructOfPrimitive
        {
            get => writeStructOfPrimitive; set
            {
                if (writeStructOfPrimitive == value)
                {
                    return;
                }

                writeStructOfPrimitive = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(WriteStructOfPrimitive)));
            }
        }
        long writeStructureOfComplex;
        public long WriteStructureOfComplex
        {
            get => writeStructureOfComplex; set
            {
                if (writeStructureOfComplex == value)
                {
                    return;
                }

                writeStructureOfComplex = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(WriteStructureOfComplex)));
            }
        }
    }
}
