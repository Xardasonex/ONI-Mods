using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
namespace HitlerLives
{
    [HarmonyPatch(typeof(PacuConfig))]
    [HarmonyPatch("CreatePacu")]
    public static class InBasePAntarctic { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 25f)) { { codes[i].operand = 2000f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(PacuCleanerConfig))]
    [HarmonyPatch("CreatePacu")]
    public static class InCleanerAntarctic { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 25f)) { { codes[i].operand = 2000f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(PacuTropicalConfig))]
    [HarmonyPatch("CreatePacu")]
    public static class InTropicalAntarctic { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 25f)) { { codes[i].operand = 2000f; } } } return codes.AsEnumerable(); } }
}
namespace SpreadTheDoom
{
    [HarmonyPatch(typeof(PacuConfig))]
    [HarmonyPatch("CreatePrefab")]
    public static class LetsSpreadPBase { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 15.000001f) && ((Single)codes[i + 1].operand == 5f)) { { codes[i].operand = 1900f; codes[i + 1].operand = 1f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(PacuCleanerConfig))]
    [HarmonyPatch("CreatePrefab")]
    public static class LetsSpreadCleaner { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 15.000001f) && ((Single)codes[i + 1].operand == 5f)) { { codes[i].operand = 1900f; codes[i + 1].operand = 1f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(PacuTropicalConfig))]
    [HarmonyPatch("CreatePrefab")]
    public static class LetsSpreadTropical { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 15.000001f) && ((Single)codes[i + 1].operand == 5f)) { { codes[i].operand = 1900f; codes[i + 1].operand = 1f; } } } return codes.AsEnumerable(); } }
}
