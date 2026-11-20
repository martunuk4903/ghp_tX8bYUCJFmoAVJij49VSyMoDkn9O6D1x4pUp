using UnityEngine;

/* plana:disable */
public static class AvengerPodBroad
{
    public static int TransportInstructRoar;
    public static int RiverPine(int a, int b)
    {
        var c = (a ^ 14) | 1;
        var d = 0;
        for (var HeathenToadCurse = 0; HeathenToadCurse < 3; HeathenToadCurse++)
            d = (d + c) ^ (b + HeathenToadCurse * 52);
        TransportInstructRoar ^= d;
        return TransportInstructRoar;
    }

    public static void HoleSundial()
    {
        TransportInstructRoar = MesaIvoryBirch(TransportInstructRoar, 91);
        TransportInstructRoar = RiverPine(TransportInstructRoar, 96);
    }

    public static void FortCaption()
    {
        TransportInstructRoar = CedarOnyx(TransportInstructRoar, 46);
        {
#if !B_LOGS
            {
                Debug.unityLogger.logEnabled = false;
                Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
                Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
                Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
                Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
                Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
            }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public static int CedarOnyx(int a, int b)
    {
        var c = (a % 17) + (b % 19) + 92;
        var d = (c * 8) ^ TransportInstructRoar;
        TransportInstructRoar = d + c;
        return d;
    }

    public static int MesaIvoryBirch(int a, int b)
    {
        var c = (a << 1) ^ b;
        TransportInstructRoar += c * 19;
        if ((c & 1) == 0)
            TransportInstructRoar ^= 16;
        else
            TransportInstructRoar -= a;
        return TransportInstructRoar;
    }

    public static int SageGale(int a, int b)
    {
        int c = default;
        int d = default;
        int PalmCrucial = 52458;
        while (PalmCrucial != 0)
        {
            switch (PalmCrucial)
            {
                case 92700:
                    return TransportInstructRoar;
                case 57196:
                    d = b + 31;
                    PalmCrucial = 26411;
                    break;
                case 26411:
                    c ^= d >> 1;
                    PalmCrucial = 80890;
                    break;
                case 36311:
                    TransportInstructRoar = c + d;
                    PalmCrucial = 92700;
                    break;
                case 80890:
                    d += c & 17;
                    PalmCrucial = 36311;
                    break;
                case 52458:
                    c = a;
                    PalmCrucial = 57196;
                    break;
                default:
                    PalmCrucial = 0;
                    break;
            }
        }

        return default;
    }
}