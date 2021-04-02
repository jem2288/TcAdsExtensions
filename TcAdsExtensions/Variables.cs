namespace TcAdsExtensions
{
    public class PLC_Vars 
    {
        public PLC_Global_Version Global_Version;
        public class PLC_Global_Version
        {
            public ST_LibVersion stLibVersion_Tc2_Standard;
            public ST_LibVersion stLibVersion_Tc2_System;
            public ST_LibVersion stLibVersion_Tc3_Module;
            public ST_LibVersion stLibVersion_Tc2_Utilities;
            public PLC_Global_Version()
            {
                stLibVersion_Tc2_Standard = new ST_LibVersion();
                stLibVersion_Tc2_System = new ST_LibVersion();
                stLibVersion_Tc3_Module = new ST_LibVersion();
                stLibVersion_Tc2_Utilities = new ST_LibVersion();
            }
        }
        public PLC_MAIN MAIN;
        public class PLC_MAIN
        {
            public int iMainTest;
            public E_TestEnum eMainTest;
            public ST_MainTest stMainTest;
            public string sMainTest;
            public string sTimeTest;
            public FB_LocalSystemTime fbSystemTime;
            public int aTestArray;
            public PLC_MAIN()
            {
                iMainTest = new int();
                eMainTest = new E_TestEnum();
                stMainTest = new ST_MainTest();
                sMainTest = string.Empty;
                sTimeTest = string.Empty;
                fbSystemTime = new FB_LocalSystemTime();
                aTestArray = new int();
            }
        }
        public PLC_GVL GVL;
        public class PLC_GVL
        {
            public FB_Testing fbTesting;
            public TestStructComplex PlcStructComplex;
            public PLC_GVL()
            {
                fbTesting = new FB_Testing();
                PlcStructComplex = new TestStructComplex();
            }
        }
        /// <summary>
        /// Top level of PLC variables coming across ADS
        /// </summary>
        public PLC_Vars()
        {
            Global_Version = new PLC_Global_Version();
            MAIN = new PLC_MAIN();
            GVL = new PLC_GVL();
        }
    }
}
