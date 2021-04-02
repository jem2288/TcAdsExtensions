using System;
using TcAdsExtensions.ADS;
using Newtonsoft.Json;
using TwinCAT;
using TwinCAT.Ads;
using TwinCAT.Ads.TypeSystem;
using TwinCAT.TypeSystem;

namespace TcAdsExtensions
{
    class Program
    {
        static void Main(string[] args)
        {

            using (TcAdsClient client = new TcAdsClient())
            {
                uint valueToRead = 0;
                uint valueToWrite = 42;

                client.Connect(AmsNetId.Local, 851);

                // Load all Symbols + DataTypes
                // Primitive Parts will be automatically resolved to .NET Primitive types.
                IDynamicSymbolLoader loader = (IDynamicSymbolLoader)SymbolLoaderFactory.Create(client, SymbolLoaderSettings.DefaultDynamic);

                dynamic symbols = loader.SymbolsDynamic;
                dynamic GVL = symbols.GVL;

                // Use typed object to use InfoTips
                //DynamicSymbol iCustomEvent = GVL.iCustomEvent; // UDINT

                // or to be fullDynamic 
                //dynamic nCounter = main.nCounter;

                // Works for ALL sorts of types (not restricted to ANY_TYPE basing primitive types)
                //valueToRead = (uint)nCounter.ReadValue();
                // or
                //var varValue = nCounter.ReadValue();
                // or
                dynamic iCustomEvent = GVL.iCustomEvent.ReadValue();

                // Same for writing
                //nCounter.WriteValue(valueToWrite);

                // Or Notifications / Events
                //nCounter.ValueChanged += NCounter_ValueChanged;

                //Reading complexTypes e.g. Struct

                DynamicSymbol myStructSymbol = GVL.PlcStructComplex; // Dynamically created
                dynamic myStructVal = myStructSymbol.ReadValue(); // Takes an ADS Snapshot of the value

                //dynamic int1Val = myStructVal.int1; // Value to an INT (short)
                //dynamic valueNestedStruct = myStructVal.nestedStruct; //value to another complex type (here a nested Struct)

                myStructSymbol.ValueChanged += MyStructSymbol_ValueChanged;                
                Console.ReadLine();
            }            
        }

        private static void NCounter_ValueChanged(object sender, ValueChangedArgs e)
        {
            var uintVal = e.Value;
        }

        private static void MyStructSymbol_ValueChanged(object sender, ValueChangedArgs e)
        {
            dynamic structValue = e.Value; // Snapshot of the whole Struct and all its contents
            Console.WriteLine(JsonConvert.SerializeObject(structValue));
            Console.WriteLine("Waiting for structure value to change");
        }

        // called onchange of any subscribed symbol
        private static void Connection_OnSymbolValueChanged(object sender, object e)
        {
            string symbolPath = (string)sender;
            object val;

            switch (symbolPath)
            {
                case "GVL.iEventData1":
                    val = (int)e;
                    break;
                case "GVL.fEventData2":
                    val = (float)e;
                    break;
                default:
                    return;
            }

            Console.WriteLine("Global OnChange raised: ");
            Console.WriteLine($"{symbolPath} vale = {val.ToString()}.");            
        }

        // called onchange for specified symbol
        private static void Connection_CustomValueChanged(object Value)
        {
            int val = (int)Value;
            Console.WriteLine("Custom OnChange raised: ");
            Console.WriteLine($"Custom symbol val = {val.ToString()}.");
        }

        /// <summary>
        /// Class definition to match PLC struct
        /// </summary>
        class TestStruct
        {
            public int iVal { get; set; }
            public float fVal { get; set; }
            public string sVal { get; set; }
        }
    }
}
