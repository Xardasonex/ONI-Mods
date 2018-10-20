using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

namespace HitlerLives
{
    [HarmonyPatch(typeof(OilFloaterConfig))]
    [HarmonyPatch("CreateOilFloater")]
    public static class InAntarcticBaseO { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 100f)) { { codes[i].operand = 2000f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(OilFloaterDecorConfig))]
    [HarmonyPatch("CreateOilFloater")]
    public static class InAntarcticDecor { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 150f)) { { codes[i].operand = 2000f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(OilFloaterHighTempConfig))]
    [HarmonyPatch("CreateOilFloater")]
    public static class InAntarcticHigh { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 100f)) { { codes[i].operand = 2000f; } } } return codes.AsEnumerable(); } }
}
namespace SpreadTheDoom
{
    [HarmonyPatch(typeof(OilFloaterConfig))]
    [HarmonyPatch("CreatePrefab")]
    public static class LetsSpreadBaseO { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 60.0000038f) && ((Single)codes[i + 1].operand == 20f)) { { codes[i].operand = 1900f; codes[i + 1].operand = 1f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(OilFloaterDecorConfig))]
    [HarmonyPatch("CreatePrefab")]
    public static class LetsSpreadDecor { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 90f) && ((Single)codes[i + 1].operand == 30f)) { { codes[i].operand = 1900f; codes[i + 1].operand = 1f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(OilFloaterHighTempConfig))]
    [HarmonyPatch("CreatePrefab")]
    public static class LetsSpreadHigh { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 60.0000038f) && ((Single)codes[i + 1].operand == 20f)) { { codes[i].operand = 1900f; codes[i + 1].operand = 1f; } } } return codes.AsEnumerable(); } }
}

