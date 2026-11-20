using AndroidInstallReferrer;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using Unity.Services.RemoteConfig;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

/* plana:disable */
public struct LaserHotPackage
{
    private static int SoleHelmTombraider;
    private static int GaleEmber(int a, int b)
    {
        var c = (a + 18) ^ (b << 2);
        var d = (c & 15) + 1;
        SoleHelmTombraider = SoleHelmTombraider + c / d;
        return SoleHelmTombraider ^ 20;
    }

    private static int VineSlate(int a, int b)
    {
        var c = b == 0 ? a + 29 : a % b;
        SoleHelmTombraider ^= c + 41;
        return SoleHelmTombraider + c;
    }

    private static int YarnJade(int a, int b)
    {
        var c = a;
        switch (b % 5)
        {
            case 0:
                c += 9;
                break;
            case 1:
                c ^= 23;
                break;
            case 2:
                c |= b;
                break;
            case 3:
                c &= 9;
                break;
            default:
                c -= 23;
                break;
        }

        SoleHelmTombraider ^= c;
        return SoleHelmTombraider + c;
    }

    private static int LimeRidgeLumen(int a, int b)
    {
        var c = ((a ^ 25) << 1) ^ b;
        var d = ((b ^ 52) >> 1) ^ a;
        SoleHelmTombraider = SoleHelmTombraider + c - d;
        return SoleHelmTombraider ^ c;
    }
}