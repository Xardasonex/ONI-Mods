using Harmony;
using UnityEngine;

[HarmonyPatch(typeof(AlgaeDistilleryConfig), "ConfigureBuildingTemplate")]
public static class AlgaeDistilleryConfigDynamicOutputPatch
{
    public static void Postfix(AlgaeDistilleryConfig __instance, ref GameObject go)
    {
        float ratio;
        ratio = SADState.SADState.StateManager.State.SlimeConsumeKGsPerSecond / 0.6f;
        ElementConverter elementConverter = go.AddOrGet<ElementConverter>();

        var newConsumedElements = new[]  {new ElementConverter.ConsumedElement(SimHashes.SlimeMold.CreateTag(), 0.6f*ratio) };

        var newOutputElements = new[]    {
            new ElementConverter.OutputElement(0.2f*ratio, SimHashes.Algae, 303.15f, true, 0f, 1f, false, 0f, 0),
            new ElementConverter.OutputElement(0.400000036f*ratio, SimHashes.DirtyWater, 303.15f, true, 0f, 0.5f, false, 0f, 0)   };

      elementConverter.outputElements = newOutputElements;
      elementConverter.consumedElements = newConsumedElements;
      ManualDeliveryKG manualDeliveryKG = go.AddOrGet<ManualDeliveryKG>();
      manualDeliveryKG.refillMass = 120f*ratio;
      manualDeliveryKG.capacity = 480f*ratio;
      AlgaeDistillery algaeDistillery = go.AddOrGet<AlgaeDistillery>();
      algaeDistillery.emitMass = 30f*ratio;
    }  
}