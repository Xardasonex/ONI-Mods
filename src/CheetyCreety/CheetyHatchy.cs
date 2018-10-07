using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

namespace HitlerLives
{
    [HarmonyPatch(typeof(HatchConfig), "CreateHatch")]
    public static class InBaseAntarctic { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 100f) && (codes[i + 1].opcode == OpCodes.Ldarg_1)) { { codes[i].operand = 2000f; } } } return codes.AsEnumerable(); } }
[HarmonyPatch(typeof(HatchHardConfig), "CreateHatch")]
    public static class InHardAntarctic { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 100f) && (codes[i + 1].opcode == OpCodes.Ldarg_1)) { { codes[i].operand = 2000f; } } } return codes.AsEnumerable(); } }
[HarmonyPatch(typeof(HatchMetalConfig), "CreateHatch")]
    public static class InMetalAntarctic { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 100f) && (codes[i + 1].opcode == OpCodes.Ldarg_1)) { { codes[i].operand = 2000f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(HatchVeggieConfig), "CreateHatch")]
    public static class InVeggieAntarctic { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 100f) && (codes[i + 1].opcode == OpCodes.Ldarg_1)) { { codes[i].operand = 2000f; } } } return codes.AsEnumerable(); } }
}
namespace SpreadTheDoom
{
    [HarmonyPatch(typeof(HatchConfig), "CreatePrefab")]
    public static class LetsSpreadBase { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 60.0000038f) && ((Single)codes[i + 1].operand == 20f)) { { codes[i].operand = 1900f; codes[i + 1].operand = 1f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(HatchHardConfig), "CreatePrefab")]
    public static class LetsSpreadHard { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 60.0000038f) && ((Single)codes[i + 1].operand == 20f)) { { codes[i].operand = 1900f; codes[i + 1].operand = 1f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(HatchMetalConfig), "CreatePrefab")]
    public static class LetsSpreadMetal { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 60.0000038f) && ((Single)codes[i + 1].operand == 20f)) { { codes[i].operand = 1900f; codes[i + 1].operand = 1f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(HatchVeggieConfig), "CreatePrefab")]
    public static class LetsSpreadVeggie { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 60.0000038f) && ((Single)codes[i + 1].operand == 20f)) { { codes[i].operand = 1900f; codes[i + 1].operand = 1f; } } } return codes.AsEnumerable(); } }
}
