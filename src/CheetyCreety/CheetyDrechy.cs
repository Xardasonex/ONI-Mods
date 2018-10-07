using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
namespace HitlerLives
{
    [HarmonyPatch(typeof(DreckoConfig), "CreateDrecko")]
    public static class InBaseDAntarctic { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 150f)) { { codes[i].operand = 2000f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(DreckoPlasticConfig), "CreateDrecko")]
    public static class InPlasticAntarctic { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 150f)) { { codes[i].operand = 2000f; } } } return codes.AsEnumerable(); } }
}
namespace SpreadTheDoom
{
    [HarmonyPatch(typeof(DreckoConfig), "CreatePrefab")]
    public static class LetsSpreadBaseD { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 90f) && ((Single)codes[i + 2].operand == 30f)) { { codes[i].operand = 1900f; codes[i + 2].operand = 1f; } } } return codes.AsEnumerable(); } }
    [HarmonyPatch(typeof(DreckoPlasticConfig), "CreatePrefab")]
    public static class LetsSpreadPlastic { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 90f) && ((Single)codes[i + 2].operand == 30f)) { { codes[i].operand = 1900f; codes[i + 2].operand = 1f; } } } return codes.AsEnumerable(); } }
}
