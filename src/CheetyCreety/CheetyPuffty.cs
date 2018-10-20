using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
namespace HitlerLives
{
    [HarmonyPatch(typeof(PuftConfig))]
    [HarmonyPatch("CreatePuft")]
    public static class InBasePfAntarctic { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 75f)) { { codes[i].operand = 2000f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(PuftAlphaConfig))]
    [HarmonyPatch("CreatePuftAlpha")]
    public static class InAntarcticAlpha { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 75f)) { { codes[i].operand = 2000f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(PuftBleachstoneConfig))]
    [HarmonyPatch("CreatePuftBleachstone")]
    public static class InAntarcticBleach { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 75f)) { { codes[i].operand = 2000f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(PuftOxyliteConfig))]
    [HarmonyPatch("CreatePuftOxylite")]
    public static class InAntarcticOxylite { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 75f)) { { codes[i].operand = 2000f; } } } return codes.AsEnumerable(); } }
}
namespace SpreadTheDoom
{
    [HarmonyPatch(typeof(PuftConfig))]
    [HarmonyPatch("CreatePrefab")]
    public static class LetsSpreadBasePf { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 45f) && ((Single)codes[i + 1].operand == 15f)) { { codes[i].operand = 1900f; codes[i + 1].operand = 1f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(PuftAlphaConfig))]
    [HarmonyPatch("CreatePrefab")]
    public static class LetsSpreadAlpha { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 45f) && ((Single)codes[i + 1].operand == 15f)) { { codes[i].operand = 1900f; codes[i + 1].operand = 1f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(PuftBleachstoneConfig))]
    [HarmonyPatch("CreatePrefab")]
    public static class LetsSpreadBleach { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 45f) && ((Single)codes[i + 1].operand == 15f)) { { codes[i].operand = 1900f; codes[i + 1].operand = 1f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(PuftOxyliteConfig))]
    [HarmonyPatch("CreatePrefab")]
    public static class LetsSpreadOxylite { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 45f) && ((Single)codes[i + 1].operand == 15f)) { { codes[i].operand = 1900f; codes[i + 1].operand = 1f; } } } return codes.AsEnumerable(); } }
}
