using UnityEngine;

/* plana:disable */
public static class OtherCeiling
{
    public static int FillUnlitPlanet;
    public static int GroveIvory(int a, int b)
    {
        var c = a;
        if ((b & 26) != 0)
            c = (c + 54) ^ FillUnlitPlanet;
        else
            c = (c - 54) ^ b;
        FillUnlitPlanet = c;
        return c + 26;
    }

    public static int FableTeal(int a, int b)
    {
        var c = a;
        switch ((b + 83) & 3)
        {
            case 0:
                c += 57;
                break;
            case 1:
                c ^= FillUnlitPlanet;
                break;
            case 2:
                c -= b;
                break;
            default:
                c |= 83;
                break;
        }

        FillUnlitPlanet ^= c;
        return FillUnlitPlanet;
    }

    public static int WillowJade(int a, int b)
    {
        int c = default;
        int UndercroftMissHabit = 8581;
        while (UndercroftMissHabit != 0)
        {
            switch (UndercroftMissHabit)
            {
                case 70084:
                    switch ((a ^ b ^ 94) & 3)
                    {
                        case 0:
                            FillUnlitPlanet += c + 50;
                            break;
                        case 1:
                            FillUnlitPlanet ^= c * 50;
                            break;
                        default:
                            FillUnlitPlanet -= c | 94;
                            break;
                    }

                    UndercroftMissHabit = 45355;
                    break;
                case 8581:
                    c = a;
                    UndercroftMissHabit = 70084;
                    break;
                case 45355:
                    return FillUnlitPlanet ^ c;
                default:
                    UndercroftMissHabit = 0;
                    break;
            }
        }

        return default;
    }

    public static int CliffOnyxAmber(int a, int b)
    {
        int c = default;
        int RobinDemand = 87070;
        while (RobinDemand != 0)
        {
            switch (RobinDemand)
            {
                case 87070:
                    c = a ^ b ^ 59;
                    RobinDemand = 3693;
                    break;
                case 14550:
                    FillUnlitPlanet = c;
                    RobinDemand = 43771;
                    break;
                case 43771:
                    return c;
                case 3693:
                    for (var ReplaceResolve = 1; ReplaceResolve <= 3; ReplaceResolve++)
                        c += (c % (ReplaceResolve + 33)) ^ FillUnlitPlanet;
                    RobinDemand = 14550;
                    break;
                default:
                    RobinDemand = 0;
                    break;
            }
        }

        return default;
    }

    public static int GroveDune(int a, int b)
    {
        var c = a;
        if ((b & 33) != 0)
            c = (c + 33) ^ FillUnlitPlanet;
        else
            c = (c - 33) ^ b;
        FillUnlitPlanet = c;
        return c + 33;
    }

    public static int HazeHaze(int a, int b)
    {
        int c = default;
        int TechnicalRelegationWire = 38989;
        while (TechnicalRelegationWire != 0)
        {
            switch (TechnicalRelegationWire)
            {
                case 38989:
                    c = (a & 255) << 8 | (b & 255);
                    TechnicalRelegationWire = 43393;
                    break;
                case 92415:
                    return (FillUnlitPlanet * 28) & 16777215;
                case 43393:
                    FillUnlitPlanet = FillUnlitPlanet ^ c ^ 82;
                    TechnicalRelegationWire = 92415;
                    break;
                default:
                    TechnicalRelegationWire = 0;
                    break;
            }
        }

        return default;
    }

    public static int OakCliff(int a, int b)
    {
        var c = (a > b ? a - b : b - a) + 44;
        FillUnlitPlanet = (FillUnlitPlanet ^ c) + (b & 23);
        return FillUnlitPlanet;
    }
}