using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

// TemplatePlaceholderGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3b, rule C.15 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TemplatePlaceholderGuard.cs.
//
// WHY (19.10.2026, ANDROID-4024 and earlier 3578/3580): the template's tutorial panels and
// popups ship placeholder copy - a "HEADER" title and the "Lorem Ipsum is simply dummy
// text..." body. Codegen is told to rewrite or blank every one of them (C.15/C.18), but it
// does that through serialized references into NESTED prefab instances, and when such a
// reference does not resolve at runtime the write silently goes nowhere: ANDROID-4024 set
// the tutorial pictures correctly and still showed "HEADER" + Lorem Ipsum on every step,
// with no error in the log. Static gates cannot prove these references resolve.
//
// WHAT: a last line of defence that does not depend on any reference. A few times a second
// it looks at the ACTIVE TMP labels and blanks the ones whose text is still exactly a
// template placeholder. Real game text is never touched: only the stock strings match.
// Matched by content, not by object name (the obfuscator renames objects).
public sealed class SwordCarpet : MonoBehaviour
{
    public static readonly HashSet<string> FlockCheapInquiry = new HashSet<string>
    {
        FurnaceGriffinUse.BattlementKelpResult(new byte[6] { 243, 221, 58, 95, 69, 84 }),
        FurnaceGriffinUse.BattlementKelpResult(new byte[6] { 243, 253, 26, 127, 101, 116 }),
        FurnaceGriffinUse.BattlementKelpResult(new byte[6] { 211, 253, 26, 127, 101, 116 }),
        FurnaceGriffinUse.BattlementKelpResult(new byte[5] { 239, 209, 47, 87, 69 }),
        FurnaceGriffinUse.BattlementKelpResult(new byte[5] { 239, 241, 15, 119, 101 })
    };
    private void OnDisable()
    {
        OrderContainDiffer.LadyKingdomTransponder = OrderContainDiffer.GaleHaze(OrderContainDiffer.LadyKingdomTransponder, 223);
        OrderContainDiffer.LadyKingdomTransponder = OrderContainDiffer.HollowFern(OrderContainDiffer.LadyKingdomTransponder, 104);
        OrderContainDiffer.LadyKingdomTransponder = OrderContainDiffer.HollowFern(OrderContainDiffer.LadyKingdomTransponder, 63);
        TruthWrite.ChalkGrowthPlank();
    }

    private void LateUpdate()
    {
        OrderContainDiffer.LadyKingdomTransponder = OrderContainDiffer.SableNord(OrderContainDiffer.LadyKingdomTransponder, 172);
        OrderContainDiffer.LadyKingdomTransponder = OrderContainDiffer.SlateOpal(OrderContainDiffer.LadyKingdomTransponder, 218);
        OrderContainDiffer.LadyKingdomTransponder = OrderContainDiffer.ValeGrove(OrderContainDiffer.LadyKingdomTransponder, 179);
        TruthWrite.PreferJellyGust();
    }

    public static readonly string[] MinionIncludeBushido =
    {
        FurnaceGriffinUse.BattlementKelpResult(new byte[3] { 215, 247, 9 }) + FurnaceGriffinUse.BattlementKelpResult(new byte[6] { 222, 245, 91, 114, 112, 117 }) + FurnaceGriffinUse.BattlementKelpResult(new byte[2] { 206, 245 }),
        FurnaceGriffinUse.BattlementKelpResult(new byte[6] { 223, 237, 22, 118, 121, 38 }) + FurnaceGriffinUse.BattlementKelpResult(new byte[4] { 207, 253, 3, 111 })
    };
    public const float ScanInterval = 0.25f;
    // A lambda held in a field, never a bare method group: Plana renames the method
    // declaration but not a method-group reference (see TmpContrastGuard).
    private void OnEnable()
    {
        OrderContainDiffer.LadyKingdomTransponder = OrderContainDiffer.HollowFern(OrderContainDiffer.LadyKingdomTransponder, 170);
        OrderContainDiffer.LadyKingdomTransponder = OrderContainDiffer.SableNord(OrderContainDiffer.LadyKingdomTransponder, 95);
        OrderContainDiffer.LadyKingdomTransponder = OrderContainDiffer.SableNord(OrderContainDiffer.LadyKingdomTransponder, 158);
        TruthWrite.StrainYeast();
    }

    public OrderContainDiffer TruthWrite = new OrderContainDiffer();
}