using System;

public class ST_LibVersion
{
    public uint iMajor;
    public uint iMinor;
    public uint iBuild;
    public uint iRevision;
    public uint nFlags;
    public string sVersion;
}

public class TestStructComplex
{
    public uint iVal;
    public float fVal;
	public string sVal;
	public TestStruct2 stTest;
}

public class TestStruct2
{
    public bool bTest;
	public float fTestLreal;
	public string sTest;
}
public enum E_WATCHDOG_TIME_CONFIG
{
    eWATCHDOG_TIME_DISABLED = 0,
    eWATCHDOG_TIME_SECONDS = 1,
    eWATCHDOG_TIME_MINUTES = 2,
}
public enum E_HashPrefixTypes
{
    HASHPREFIX_IEC = 0,
    HASHPREFIX_STDC = 1,
}
public enum E_SBCSType
{
    eSBCS_WesternEuropean = 1,
    eSBCS_CentralEuropean = 2,
}
public enum E_RouteTransportType
{
    eRouteTransport_None = 0,
    eRouteTransport_TCP_IP = 1,
    eRouteTransport_IIO_LIGHTBUS = 2,
    eRouteTransport_PROFIBUS_DP = 3,
    eRouteTransport_PCI_ISA_BUS = 4,
    eRouteTransport_ADS_UDP = 5,
    eRouteTransport_FATP_UDP = 6,
    eRouteTransport_COM_PORT = 7,
    eRouteTransport_USB = 8,
    eRouteTransport_CAN_OPEN = 9,
    eRouteTransport_DEVICE_NET = 10,
    eRouteTransport_SSB = 11,
    eRouteTransport_SOAP = 12,
}
public class ST_AmsRouteEntry
{
    public string sName;
    public string sNetID;
    public string sAddress;
    public E_RouteTransportType eTransport;
    public TimeSpan tTimeout;
    public uint dwFlags;
}
public enum E_ArgType
{
    ARGTYPE_UNKNOWN = 0,
    ARGTYPE_BYTE = 1,
    ARGTYPE_WORD = 2,
    ARGTYPE_DWORD = 3,
    ARGTYPE_REAL = 4,
    ARGTYPE_LREAL = 5,
    ARGTYPE_SINT = 6,
    ARGTYPE_INT = 7,
    ARGTYPE_DINT = 8,
    ARGTYPE_USINT = 9,
    ARGTYPE_UINT = 10,
    ARGTYPE_UDINT = 11,
    ARGTYPE_STRING = 12,
    ARGTYPE_BOOL = 13,
    ARGTYPE_BIGTYPE = 14,
    ARGTYPE_ULARGE = 15,
    ARGTYPE_UHUGE = 16,
    ARGTYPE_LARGE = 17,
    ARGTYPE_HUGE = 18,
    ARGTYPE_LWORD = 19,
}
public class T_Arg
{
    public E_ArgType eType;
    public uint cbLen;
    public uint pData;
}
public class T_ULARGE_INTEGER
{
    public uint dwLowPart;
    public uint dwHighPart;
}
public class TIMESTRUCT
{
    public uint wYear;
    public uint wMonth;
    public uint wDayOfWeek;
    public uint wDay;
    public uint wHour;
    public uint wMinute;
    public uint wSecond;
    public uint wMilliseconds;
}
public class ST_TimeZoneInformation
{
    public int bias;
    public string standardName;
    public TIMESTRUCT standardDate;
    public int standardBias;
    public string daylightName;
    public TIMESTRUCT daylightDate;
    public int daylightBias;
}
public enum E_TestEnum
{
    init = 0,
    start = 1,
    run = 2,
    complete = 3,
}
public class ST_MainTest
{
    public int iMainStructVal;
    public string sMainStructVal;
    public float rMainStructVal;
}
public enum E_TimeZoneID
{
    eTimeZoneID_Invalid = -1,
    eTimeZoneID_Unknown = 0,
    eTimeZoneID_Standard = 1,
    eTimeZoneID_Daylight = 2,
}
public class R_TRIG
{
    public bool CLK;
    public bool Q;
    public bool M;
}
public class ADSREAD
{
    public string NETID;
    public uint PORT;
    public uint IDXGRP;
    public uint IDXOFFS;
    public uint LEN;
    public uint DESTADDR;
    public bool READ;
    public TimeSpan TMOUT;
    public bool BUSY;
    public bool ERR;
    public uint ERRID;
}
public class NT_GetTime
{
    public string NETID;
    public bool START;
    public TimeSpan TMOUT;
    public bool BUSY;
    public bool ERR;
    public uint ERRID;
    public TIMESTRUCT TIMESTR;
    public ADSREAD fbAdsRead;
}
public class ST_AmsGetTimeZoneInformation
{
    public ST_TimeZoneInformation tzInfo;
    public uint apiResult;
}
public class FB_GetTimeZoneInformation
{
    public string sNetID;
    public bool bExecute;
    public TimeSpan tTimeout;
    public bool bBusy;
    public bool bError;
    public uint nErrID;
    public E_TimeZoneID tzID;
    public ST_TimeZoneInformation tzInfo;
    public ADSREAD fbAdsRead;
    public R_TRIG fbTrigger;
    public byte state;
    public ST_AmsGetTimeZoneInformation res;
}
public class ADSWRITE
{
    public string NETID;
    public uint PORT;
    public uint IDXGRP;
    public uint IDXOFFS;
    public uint LEN;
    public uint SRCADDR;
    public bool WRITE;
    public TimeSpan TMOUT;
    public bool BUSY;
    public bool ERR;
    public uint ERRID;
}
public class ADSRDWRTEX
{
    public string NETID;
    public uint PORT;
    public uint IDXGRP;
    public uint IDXOFFS;
    public uint WRITELEN;
    public uint READLEN;
    public uint SRCADDR;
    public uint DESTADDR;
    public bool WRTRD;
    public TimeSpan TMOUT;
    public bool BUSY;
    public bool ERR;
    public uint ERRID;
    public uint COUNT_R;
}
public class ST_HKeySrvRead
{
    public string sSub;
    public string sVal;
}
public class FB_RegQueryValue
{
    public string sNetId;
    public string sSubKey;
    public string sValName;
    public uint cbData;
    public byte pData;
    public bool bExecute;
    public TimeSpan tTimeOut;
    public bool bBusy;
    public bool bError;
    public uint nErrId;
    public uint cbRead;
    public ADSRDWRTEX fbAdsRdWrtEx;
    public R_TRIG fbTrigger;
    public byte state;
    public uint s1Len;
    public uint s2Len;
    public byte ptr;
    public uint cbBuff;
    public ST_HKeySrvRead tmpBuff;
}
public class NT_SetTimeToRTCTime
{
    public string NETID;
    public bool SET;
    public TimeSpan TMOUT;
    public bool BUSY;
    public bool ERR;
    public uint ERRID;
    public ADSWRITE fbAdsWrite;
    public FB_RegQueryValue fbRegQuery;
    public R_TRIG fbTrigger;
    public uint bTmp;
    public byte state;
    public bool bInit;
    public uint numOfCPUs;
}
public class FW_GetCpuCounter
{
    public uint dwCpuCntLo;
    public uint dwCpuCntHi;
}
public class GETCPUCOUNTER
{
    public uint cpuCntLoDW;
    public uint cpuCntHiDW;
    public FW_GetCpuCounter fbGetCpuCounter;
}
public class RTC_EX2
{
    public bool EN;
    public TIMESTRUCT PDT;
    public uint PMICRO;
    public bool Q;
    public TIMESTRUCT CDT;
    public uint CMICRO;
    public GETCPUCOUNTER fbGetCpuCounter;
    public R_TRIG risingEdge;
    public uint oldTick;
    public uint currTick;
    public uint nanoDiff;
    public uint nanoRest;
    public uint secDiff;
    public TimeSpan dateTime;
    public bool bInitialized;
}
public class TON
{
    public bool IN;
    public TimeSpan PT;
    public bool Q;
    public TimeSpan ET;
    public bool M;
    public TimeSpan StartTime;
}
public class FB_LocalSystemTime
{
    public string sNetID;
    public bool bEnable;
    public uint dwCycle;
    public uint dwOpt;
    public TimeSpan tTimeout;
    public bool bValid;
    public TIMESTRUCT systemTime;
    public E_TimeZoneID tzID;
    public R_TRIG rtrig;
    public byte state;
    public NT_GetTime fbNT;
    public FB_GetTimeZoneInformation fbTZ;
    public NT_SetTimeToRTCTime fbSET;
    public RTC_EX2 fbRTC;
    public TON timer;
    public uint nSync;
    public bool bNotSup;
}
public class FB_Testing
{
    public bool Busy;
    public string sStatus;
    public TON tTestTimer;
    public int aTestArray;
}
public class VERSION
{
    public uint uiMajor;
    public uint uiMinor;
    public uint uiServicePack;
    public uint uiPatch;
}
public enum EPlcPersistentStatus
{
    PS_None = 0,
    PS_All = 1,
    PS_Partial = 2,
}
public class PlcAppSystemInfo
{
    public uint ObjId;
    public uint TaskCnt;
    public uint OnlineChangeCnt;
    public uint Flags;
    public uint AdsPort;
    public bool BootDataLoaded;
    public bool OldBootData;
    public TimeSpan AppTimestamp;
    public bool KeepOutputsOnBP;
    public bool ShutdownInProgress;
    public bool LicensesPending;
    public bool BSODOccured;
    public bool LoggedIn;
    public EPlcPersistentStatus PersistentStatus;
    public uint TComSrvPtr;
    public string AppName;
    public string ProjectName;
}
public class PlcTaskSystemInfo
{
    public uint ObjId;
    public uint CycleTime;
    public uint Priority;
    public uint AdsPort;
    public uint CycleCount;
    public long DcTaskTime;
    public uint LastExecTime;
    public bool FirstCycle;
    public bool CycleTimeExceeded;
    public bool InCallAfterOutputUpdate;
    public bool RTViolation;
    public string TaskName;
}
public enum _Implicit_KindOfTask
{
    _implicit_cyclic = 0,
    _implicit_event = 1,
    _implicit_external = 2,
    _implicit_freewheeling = 3,
}
public class _Implicit_Jitter_Distribution
{
    public uint wRangeMax;
    public uint wCountJitterNeg;
    public uint wCountJitterPos;
}
public class _Implicit_Task_Info
{
    public uint dwVersion;
    public string pszName;
    public int nPriority;
    public _Implicit_KindOfTask KindOf;
    public bool bWatchdog;
    public bool bProfilingTask;
    public byte dwEventFunctionPointer;
    public string pszExternalEvent;
    public byte dwTaskEntryFunctionPointer;
    public uint dwWatchdogSensitivity;
    public uint dwInterval;
    public uint dwWatchdogTime;
    public uint dwLastCycleTime;
    public uint dwAverageCycleTime;
    public uint dwMaxCycleTime;
    public uint dwMinCycleTime;
    public int diJitter;
    public int diJitterMin;
    public int diJitterMax;
    public uint dwCycleCount;
    public uint wTaskStatus;
    public uint wNumOfJitterDistributions;
    public _Implicit_Jitter_Distribution pJitterDistribution;
    public bool bWithinSPSTimeSlicing;
    public byte byDummy;
    public bool bShouldBlock;
    public bool bActive;
    public uint dwIECCycleCount;
}
