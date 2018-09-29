using Harmony;
using System;
using System.Reflection;

[HarmonyPatch(typeof(ConduitFlow))]
[HarmonyPatch(new Type[] { typeof(ConduitType), typeof(int), typeof(IUtilityNetworkMgr), typeof(float), typeof(float) })]
public static class PipesMass
{
    public static void Prefix(ConduitType conduit_type, int num_cells, IUtilityNetworkMgr network_mgr, ref float max_conduit_mass, float initial_elapsed_time)
    {
        max_conduit_mass = PipesMass1.PipesMassState.StateManager.State.liquidandgas;
    }

}

[HarmonyPatch(typeof(SolidTransferArm))]
[HarmonyPatch("OnPrefabInit")]
class MyPatch
{
   static void Prefix(ref float ___max_carry_weight)
    {
       // ___max_carry_weight = 400f;
       ___max_carry_weight = PipesMass1.PipesMassState.StateManager.State.STA;
    }
}

