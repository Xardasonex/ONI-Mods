using System;
using Harmony;
using UnityEngine;

namespace KorribanDynamics
{
    namespace DynamicBuildings
    {
        [HarmonyPatch(typeof(MopTool), new Type[] {})]
        class MopToolPatch
        {
            static void Prefix(ref float ___maxMopAmt)
            {
                ___maxMopAmt = 9999f;
            }
        }               
    }

    namespace UI
    {
        [HarmonyPatch(typeof(MopPlacerConfig))]
        [HarmonyPatch("CreatePrefab")]
            class MopPlacerConfigPatch
            {
                public static void Postfix(MopPlacerConfig __instance, ref GameObject __result)
                {
                    Moppable moppable = __result.AddOrGet<Moppable>();
                    moppable.amountMoppedPerTick = 100f;
                }
            }
        }
}
    




