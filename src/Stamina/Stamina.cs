using Harmony;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Linq;

namespace KorribanDynamics
{
    [HarmonyPatch(typeof(MinionConfig))]
    [HarmonyPatch("CreatePrefab")]
    public static class StaminaPatch
    {
        static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            var codes = new List<CodeInstruction>(instructions);
            for (int i = 0; i < codes.Count; i++)
            {if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == -0.116666667f)){{codes[i].operand = 0f;}}}
            return codes.AsEnumerable();}}}
 
