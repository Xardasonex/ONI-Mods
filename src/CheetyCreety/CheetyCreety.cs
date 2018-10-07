using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
namespace NoOvercrowd
{
    [HarmonyPatch(typeof(OvercrowdingMonitor),"InitializeStates")]
    public static class NoSociopaths
    {
        static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            var codes = new List<CodeInstruction>(instructions);
            for (int i = 0; i < codes.Count; i++)
            {
                if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == -1f))
                {
                    {
                        codes[i].operand = 0f;
                    }
                }
                if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == -5f))
                {
                    {
                        codes[i].operand = 0f;
                    }
                }
            }
            return codes.AsEnumerable();
        }
    }
}
namespace HappyTame
{
    [HarmonyPatch(typeof(EntityTemplates),"ExtendEntityToWildCreature")]
    public static class ILikeGrooming
    {
        static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            var codes = new List<CodeInstruction>(instructions);
            for (int i = 0; i < codes.Count; i++)
            {
                if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == -1f))
                {
                    {
                        codes[i].operand = 2f;
                    }
                }
            }
            return codes.AsEnumerable();
        }
    }
}
/*namespace ImmortalJoe //Saves coding time but it's bad cause the babies doesn't grow
{
    [HarmonyPatch(typeof(AgeMonitor), "InitializeStates")]
    public static class ILikeg
    {
        static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            var codes = new List<CodeInstruction>(instructions);
            for (int i = 0; i < codes.Count; i++)
            {
                if ((codes[i].opcode == OpCodes.Ldc_R4) && ((Single)codes[i].operand == 0.00166666671f))
                {
                    {
                        codes[i].operand = 0f;
                    }
                }
            }
            return codes.AsEnumerable();
        }
    }
}*/

    