using System;
using UnityEngine;

public static class NadirUplinkKeepwatch
{
    public static string[] CrowNestEmbark { get; } = new string[]
    {
        FurnaceGriffinUse.BattlementKelpResult(new byte[10] { 254, 213, 57, 94, 82, 38, 174, 134, 248, 217 }),
        FurnaceGriffinUse.BattlementKelpResult(new byte[8] { 239, 208, 50, 85, 32, 71, 181, 149 }),
        FurnaceGriffinUse.BattlementKelpResult(new byte[12] { 243, 221, 58, 77, 89, 38, 191, 142, 255, 211, 34, 77 }),
        FurnaceGriffinUse.BattlementKelpResult(new byte[10] { 248, 215, 55, 95, 32, 80, 185, 137, 229, 196 }),
        FurnaceGriffinUse.BattlementKelpResult(new byte[10] { 253, 217, 40, 79, 32, 82, 174, 134, 248, 219 }),
    };

    public static string ModifierRule()
    {
        SheetCritic.SufferVisionPoacher = SheetCritic.ValeHaze(SheetCritic.SufferVisionPoacher, 167);
        return FuseEvergreenFen[ModifierIndex()];
    }

    public static int ModifierIndex()
    {
        SheetCritic.SufferVisionPoacher = SheetCritic.IvoryRiver(SheetCritic.SufferVisionPoacher, 44);
        return Mathf.Abs(SheetCritic.DayIndex()) % CrowNestEmbark.Length;
    }

    public static string[] FuseEvergreenFen { get; } = new string[]
    {
        FurnaceGriffinUse.BattlementKelpResult(new byte[29] { 255, 215, 46, 89, 76, 67, 220, 130, 252, 213, 34, 77, 49, 21, 207, 141, 248, 196, 45, 102, 127, 70, 233, 213, 227, 244, 198, 40, 23 }),
        FurnaceGriffinUse.BattlementKelpResult(new byte[28] { 248, 208, 58, 73, 71, 67, 220, 131, 227, 214, 46, 81, 49, 25, 174, 229, 237, 192, 34, 20, 111, 46, 234, 180, 230, 229, 205, 46 }),
        FurnaceGriffinUse.BattlementKelpResult(new byte[28] { 254, 206, 62, 73, 89, 38, 180, 134, 235, 214, 53, 91, 66, 122, 160, 150, 237, 219, 75, 119, 25, 46, 239, 189, 244, 227, 207, 57 }),
        FurnaceGriffinUse.BattlementKelpResult(new byte[22] { 237, 221, 53, 79, 83, 38, 174, 130, 247, 222, 43, 83, 66, 11, 221, 229, 250, 192, 42, 20, 108, 75 }),
        FurnaceGriffinUse.BattlementKelpResult(new byte[32] { 239, 208, 62, 59, 84, 84, 189, 142, 253, 183, 52, 75, 35, 107, 187, 150, 153, 199, 37, 3, 11, 93, 248, 176, 229, 145, 206, 61, 23, 102, 13, 229 }),
    };

    public static string ModifierName()
    {
        SheetCritic.SufferVisionPoacher = SheetCritic.GlenFern(SheetCritic.SufferVisionPoacher, 171);
        SheetCritic.SufferVisionPoacher = SheetCritic.BirchUmber(SheetCritic.SufferVisionPoacher, 106);
        SheetCritic.SufferVisionPoacher = SheetCritic.YarnJade(SheetCritic.SufferVisionPoacher, 84);
        return CrowNestEmbark[ModifierIndex()];
    }
}