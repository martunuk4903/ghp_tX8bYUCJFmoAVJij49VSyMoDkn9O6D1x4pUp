/* plana:disable */
public static class SurveyDiscoverTalk
{
    public static int UnlikeStoryline;
    public static int BriarLagoon(int a, int b)
    {
        int c = default;
        int OnlyGleam = 87652;
        while (OnlyGleam != 0)
        {
            switch (OnlyGleam)
            {
                case 99751:
                    if ((b & 56) != 0)
                        c = (c + 33) ^ UnlikeStoryline;
                    else
                        c = (c - 33) ^ b;
                    OnlyGleam = 24344;
                    break;
                case 87652:
                    c = a;
                    OnlyGleam = 99751;
                    break;
                case 24344:
                    UnlikeStoryline = c;
                    OnlyGleam = 47941;
                    break;
                case 47941:
                    return c + 56;
                default:
                    OnlyGleam = 0;
                    break;
            }
        }

        return default;
    }

    public static int BirchVerde(int a, int b)
    {
        int c = default;
        int d = default;
        int JudgeFocus = 92337;
        while (JudgeFocus != 0)
        {
            switch (JudgeFocus)
            {
                case 40026:
                    UnlikeStoryline = d + c;
                    JudgeFocus = 89424;
                    break;
                case 92337:
                    c = (a & 88) ^ (b | 13);
                    JudgeFocus = 67858;
                    break;
                case 89424:
                    return UnlikeStoryline;
                case 67858:
                    d = c ^ (UnlikeStoryline >> 1);
                    JudgeFocus = 40026;
                    break;
                default:
                    JudgeFocus = 0;
                    break;
            }
        }

        return default;
    }

    public static int MapleMesaUmbra(int a, int b)
    {
        var c = (a | 13) ^ (b & 9);
        var d = (c + UnlikeStoryline) ^ (c - a);
        UnlikeStoryline = d;
        return d ^ 13;
    }

    public static int DeltaKelpYarn(int a, int b)
    {
        var c = a;
        var d = 29;
        c = (c + b) * d + 30;
        d = (d ^ c) & 255;
        UnlikeStoryline ^= c + d;
        return UnlikeStoryline;
    }

    public static int SageVineYarn(int a, int b)
    {
        int c = default;
        int d = default;
        int DefenceSpecies = 94449;
        while (DefenceSpecies != 0)
        {
            switch (DefenceSpecies)
            {
                case 86946:
                    if (c > d)
                        UnlikeStoryline += c - d;
                    else
                        UnlikeStoryline ^= d - c;
                    DefenceSpecies = 32546;
                    break;
                case 94449:
                    c = a + 27;
                    DefenceSpecies = 10919;
                    break;
                case 10919:
                    d = b - 39;
                    DefenceSpecies = 86946;
                    break;
                case 32546:
                    return UnlikeStoryline;
                default:
                    DefenceSpecies = 0;
                    break;
            }
        }

        return default;
    }
}