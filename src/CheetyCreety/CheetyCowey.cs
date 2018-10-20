using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
namespace HitlerLives
{
    [HarmonyPatch(typeof(MooConfig))]
    [HarmonyPatch("CreateMoo")]
    public static class ThereIsNoCowLevel { static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions) { var codes = new List<CodeInstruction>(instructions); for (int i = 0; i < codes.Count; i++) { if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 75f)) { { codes[i].operand = 2000f; } } } return codes.AsEnumerable(); } }
}
    