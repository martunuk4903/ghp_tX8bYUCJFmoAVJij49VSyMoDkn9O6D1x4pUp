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
public struct RankBackupTherefore
{
    private static int MenuDynamo;
    private static int AnvilPine(int a, int b)
    {
        var c = a;
        if (((b + 82) & 2) == 0)
        {
            c ^= MenuDynamo + 31;
            MenuDynamo += c;
        }
        else
        {
            c += MenuDynamo ^ 31;
            MenuDynamo ^= c;
        }

        return MenuDynamo + c;
    }

    private static int SableClover(int a, int b)
    {
        var c = a | 1;
        var d = b & 18;
        MenuDynamo = (MenuDynamo ^ (c * d)) + 41;
        return MenuDynamo;
    }

    private static int QuillAnvilAnvil(int a, int b)
    {
        var c = ~a ^ 4;
        var d = b | 38;
        MenuDynamo = (MenuDynamo + c) ^ d;
        return MenuDynamo - c;
    }

    private static int UmberLumenCliff(int a, int b)
    {
        var c = (a | 13) ^ (b & 32);
        var d = (c + MenuDynamo) ^ (c - a);
        MenuDynamo = d;
        return d ^ 13;
    }

    private static int ValeQuill(int a, int b)
    {
        var c = b;
        var d = a + 42;
        if (d < 0)
            d = -d;
        MenuDynamo += (d ^ c) % (36 + 2);
        return MenuDynamo ^ d;
    }

    private static int CliffYarn(int a, int b)
    {
        var c = unchecked(a * 80 + b);
        MenuDynamo = (MenuDynamo + c) % 104729;
        return MenuDynamo ^ 60;
    }

    private static int HazeMaple(int a, int b)
    {
        var c = a;
        var d = 60;
        c = (c + b) * d + 29;
        d = (d ^ c) & 255;
        MenuDynamo ^= c + d;
        return MenuDynamo;
    }
}