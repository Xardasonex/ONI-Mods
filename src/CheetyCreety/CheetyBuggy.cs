using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

namespace HitlerLives
{
    [HarmonyPatch(typeof(LightBugConfig))]
    [HarmonyPatch("CreateLightBug")]
    public static class InAntarctic0 { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 25f) && (codes[i + 1].opcode == OpCodes.Ldarg_1)) { { codes[i].operand = 2000f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(LightBugBlueConfig))]
    [HarmonyPatch("CreateLightBug")]
    public static class InAntarctic1 { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 25f) && (codes[i + 1].opcode == OpCodes.Ldarg_1)) { { codes[i].operand = 2000f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(LightBugOrangeConfig))]
    [HarmonyPatch("CreateLightBug")]
    public static class InAntarctic2 { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 25f) && (codes[i + 1].opcode == OpCodes.Ldarg_1)) { { codes[i].operand = 2000f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(LightBugPinkConfig))]
    [HarmonyPatch("CreateLightBug")]
    public static class InAntarctic3 { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 25f) && (codes[i + 1].opcode == OpCodes.Ldarg_1)) { { codes[i].operand = 2000f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(LightBugPurpleConfig))]
    [HarmonyPatch("CreateLightBug")]
    public static class InAntarctic4 { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 25f) && (codes[i + 1].opcode == OpCodes.Ldarg_1)) { { codes[i].operand = 2000f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(LightBugCrystalConfig))]
    [HarmonyPatch("CreateLightBug")]
    public static class InAntarctic5 { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 75f) && (codes[i + 1].opcode == OpCodes.Ldarg_1)) { { codes[i].operand = 2000f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(LightBugBlackConfig))]
    [HarmonyPatch("CreateLightBug")]
    public static class InAntarctic6 { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 75f) && (codes[i + 1].opcode == OpCodes.Ldarg_1)) { { codes[i].operand = 2000f; } } } return codes.AsEnumerable(); } }
}
namespace SpreadTheDoom
{
    [HarmonyPatch(typeof(LightBugConfig))]
    [HarmonyPatch("CreatePrefab")]
    public static class LetsSpread0 { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 15.000001f) && ((Single)codes[i + 1].operand == 5f)) { { codes[i].operand = 1900f; codes[i + 1].operand = 1f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(LightBugBlueConfig))]
    [HarmonyPatch("CreatePrefab")]
    public static class LetsSpread1 { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 15.000001f) && ((Single)codes[i + 1].operand == 5f)) { { codes[i].operand = 1900f; codes[i + 1].operand = 1f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(LightBugOrangeConfig))]
    [HarmonyPatch("CreatePrefab")]
    public static class LetsSpread2 { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 15.000001f) && ((Single)codes[i + 1].operand == 5f)) { { codes[i].operand = 1900f; codes[i + 1].operand = 1f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(LightBugPinkConfig))]
    [HarmonyPatch("CreatePrefab")]
    public static class LetsSpread3 { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 15.000001f) && ((Single)codes[i + 1].operand == 5f)) { { codes[i].operand = 1900f; codes[i + 1].operand = 1f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(LightBugPurpleConfig))]
    [HarmonyPatch("CreatePrefab")]
    public static class LetsSpread4 { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 15.000001f) && ((Single)codes[i + 1].operand == 5f)) { { codes[i].operand = 1900f; codes[i + 1].operand = 1f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(LightBugCrystalConfig))]
    [HarmonyPatch("CreatePrefab")]
    public static class LetsSpread5 { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 45f) && ((Single)codes[i + 1].operand == 15f)) { { codes[i].operand = 1900f; codes[i + 1].operand = 1f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(LightBugBlackConfig))]
    [HarmonyPatch("CreatePrefab")]
    public static class LetsSpread6 { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 45f) && ((Single)codes[i + 1].operand == 15f)) { { codes[i].operand = 1900f; codes[i + 1].operand = 1f; } } } return codes.AsEnumerable(); } }
}











