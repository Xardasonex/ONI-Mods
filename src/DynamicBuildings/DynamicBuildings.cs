using Harmony;
using STRINGS;
using System;
using UnityEngine;
using Klei;
namespace KorribanDynamics
{

    [HarmonyPatch(typeof(ConduitFlow))]
    [HarmonyPatch(new Type[] { typeof(ConduitType), typeof(int), typeof(IUtilityNetworkMgr), typeof(float), typeof(float) })]
    public static class PipesMass
    {
        public static void Prefix(ConduitType conduit_type, int num_cells, IUtilityNetworkMgr network_mgr, ref float max_conduit_mass, float initial_elapsed_time)
        { max_conduit_mass = DynamicBuildingsState.StateManager.State.liquidandgas; }
    }

    [HarmonyPatch(typeof(SolidTransferArm), "OnPrefabInit")]
    class SweeperCarryCapacityPatch { static void Prefix(ref float ___max_carry_weight) { ___max_carry_weight = DynamicBuildingsState.StateManager.State.STA; } }



    [HarmonyPatch(typeof(OilRefineryConfig), "ConfigureBuildingTemplate")]
    public static class OilRefineryDynamicOutputPatch
    {
        public static void Postfix(OilRefineryConfig __instance, ref GameObject go)
        {
            float ratio;
            ratio = DynamicBuildingsState.StateManager.State.liquidandgas / 10f;
            ConduitConsumer conduitConsumer = go.AddOrGet<ConduitConsumer>();
            conduitConsumer.consumptionRate = 10 * ratio;
            conduitConsumer.capacityKG = 1000 * ratio;
            ElementConverter elementConverter = go.AddOrGet<ElementConverter>();
            var newOutputElements = new[]    {
            new ElementConverter.OutputElement(5*ratio, SimHashes.Petroleum, 348.15f, true, 0f, 1f, false, 0f, 0),
            new ElementConverter.OutputElement(0.09f*ratio, SimHashes.Methane, 348.15f, true, 0f, 1f, false, 0f, 0)
        };
            var newConsumedElements = new[] { new ElementConverter.ConsumedElement(SimHashes.CrudeOil.CreateTag(), 10 * ratio) };

            elementConverter.outputElements = newOutputElements;
            elementConverter.consumedElements = newConsumedElements;
        }
    }

    [HarmonyPatch(typeof(AlgaeDistilleryConfig), "ConfigureBuildingTemplate")]
    public static class AlgaeDistilleryConfigDynamicOutputPatch
    {
        public static void Postfix(AlgaeDistilleryConfig __instance, ref GameObject go)
        {
            float ratio;
            ratio = DynamicBuildingsState.StateManager.State.SlimeConsumeKGsPerSecond / 0.6f;
            ManualDeliveryKG manualDeliveryKG = go.AddOrGet<ManualDeliveryKG>();
            manualDeliveryKG.refillMass = 120f * ratio;
            manualDeliveryKG.capacity = 480f * ratio;
            AlgaeDistillery algaeDistillery = go.AddOrGet<AlgaeDistillery>();
            algaeDistillery.emitMass = 30f * ratio;

            ElementConverter elementConverter = go.AddOrGet<ElementConverter>();

            var newConsumedElements = new[] { new ElementConverter.ConsumedElement(SimHashes.SlimeMold.CreateTag(), 0.6f * ratio) };

            var newOutputElements = new[]    {
            new ElementConverter.OutputElement(0.2f*ratio, SimHashes.Algae, 303.15f, true, 0f, 1f, false, 0f, 0),
            new ElementConverter.OutputElement(0.400000036f*ratio, SimHashes.DirtyWater, 303.15f, true, 0f, 0.5f, false, 0f, 0)   };

            elementConverter.outputElements = newOutputElements;
            elementConverter.consumedElements = newConsumedElements;
        }
    }

[HarmonyPatch(typeof(OilRefineryConfig), "CreateBuildingDef")]
    class OilRefineryRotationsPatch {
        public static void Postfix(OilRefineryConfig __instance, ref BuildingDef __result)
        {
            __result.PermittedRotations = PermittedRotations.FlipH; } }



[HarmonyPatch(typeof(LiquidLogicValveConfig), "ConfigureBuildingTemplate")]
class LiquidLogicValveConfigDynamicPatch
    {
        public static void Postfix(LiquidLogicValveConfig __instance, ref GameObject go)
        {
         OperationalValve operationalValve = go.AddOrGet<OperationalValve>();
        operationalValve.maxFlow = DynamicBuildingsState.StateManager.State.liquidandgas;
        }
}
    
[HarmonyPatch(typeof(GasLogicValveConfig), "ConfigureBuildingTemplate")]
class GasLogicValveConfigDynamicPatch
    {
        public static void Postfix(GasLogicValveConfig __instance, ref GameObject go)
        {
            OperationalValve operationalValve = go.AddOrGet<OperationalValve>();
            operationalValve.maxFlow = DynamicBuildingsState.StateManager.State.liquidandgas;
        }
    }
    
[HarmonyPatch(typeof(LiquidPumpConfig), "DoPostConfigureComplete")]
    class LiquidPumpConfigDynamicPatch
    {
        public static void Postfix(LiquidPumpConfig __instance, ref GameObject go)
        {
            float ratio = DynamicBuildingsState.StateManager.State.liquidandgas;
            byte radius = DynamicBuildingsState.StateManager.State.SuckInRadius;
            Storage storage = go.AddOrGet<Storage>();
            storage.capacityKg = 5*ratio;
            ElementConsumer elementConsumer = go.AddOrGet<ElementConsumer>();
            elementConsumer.consumptionRate = ratio;
            elementConsumer.consumptionRadius = radius;
        }
    }

[HarmonyPatch(typeof(GasPumpConfig), "DoPostConfigureComplete")]
    class GasPumpConfigDynamicPatch
    {
        public static void Postfix(GasPumpConfig __instance, ref GameObject go)
        {
            float ratio = DynamicBuildingsState.StateManager.State.liquidandgas;
            byte radius = DynamicBuildingsState.StateManager.State.SuckInRadius;
            Storage storage = go.AddOrGet<Storage>();
            storage.capacityKg = 5 * ratio;
            ElementConsumer elementConsumer = go.AddOrGet<ElementConsumer>();
            elementConsumer.consumptionRate = ratio;
            elementConsumer.consumptionRadius = radius;
        }
    }
[HarmonyPatch(typeof(GasMiniPumpConfig), "DoPostConfigureComplete")]
    class GasMiniPumpConfigDynamicPatch
    {
        public static void Postfix(GasMiniPumpConfig __instance, ref GameObject go)
        {
            float ratio = DynamicBuildingsState.StateManager.State.liquidandgas;
            byte radius = DynamicBuildingsState.StateManager.State.SuckInRadius;
            Storage storage = go.AddOrGet<Storage>();
            storage.capacityKg = 5 * ratio;
            ElementConsumer elementConsumer = go.AddOrGet<ElementConsumer>();
            elementConsumer.consumptionRate = ratio;
            elementConsumer.consumptionRadius = radius;
        }
    }
    [HarmonyPatch(typeof(LiquidMiniPumpConfig), "DoPostConfigureComplete")]
    class LiquidMiniPumpConfigDynamicPatch
    {
        public static void Postfix(LiquidMiniPumpConfig __instance, ref GameObject go)
        {
            float ratio = DynamicBuildingsState.StateManager.State.liquidandgas;
            byte radius = DynamicBuildingsState.StateManager.State.SuckInRadius;
            Storage storage = go.AddOrGet<Storage>();
            storage.capacityKg = 5 * ratio;
            ElementConsumer elementConsumer = go.AddOrGet<ElementConsumer>();
            elementConsumer.consumptionRate = ratio;
            elementConsumer.consumptionRadius = radius;
        }
    }

}
















/*
[HarmonyPatch(typeof(OilRefineryConfig))]
public class NewPort
{
   public static void Prefix(GameObject go)
    {
       ConduitPortInfo secondaryPort = new ConduitPortInfo(ConduitType.Gas, new CellOffset(0, 1));
        ConduitSecondaryOutput conduitSecondaryOutput = go.AddComponent<ConduitSecondaryOutput>();
        conduitSecondaryOutput.portInfo = secondaryPort;
    }
}

[HarmonyPatch(typeof(SolidConduitDispenser))]
[HarmonyPatch("OnPrefabInit")]
class MyPatch12
{
    static void Prefix(ref float ___MaxMass)
    {
        ___MaxMass = 60f;
    }
}

[HarmonyPatch(typeof(SolidConduitDispenser), "ConduitUpdate")]
class My2Patch
{
   static void Prefix(SolidConduitDispenser __instance, ref float dt, ref Operational operational,ref int utilityCell, bool dispensing, Operational.Flag ___outputConduitFlag)
    {
        bool flag = false;
        operational.SetFlag(___outputConduitFlag, __instance.IsConnected);
        if (operational.IsOperational || __instance.alwaysDispense)
        {
            SolidConduitFlow conduitFlow = __instance.GetConduitFlow();
            if (conduitFlow.HasConduit(utilityCell) && conduitFlow.IsConduitEmpty(utilityCell))
            {
                Pickupable pickupable = Traverse.Create(__instance).Method("FindSuitableItem").GetValue<Pickupable>();
                if ((bool)pickupable)
                {
                    if (pickupable.PrimaryElement.Mass > 100f)
                    {
                        pickupable = pickupable.Take(100f);
                    }
                    conduitFlow.AddPickupable(utilityCell, pickupable);
                    flag = true;
                }}}
        __instance.storage.storageNetworkID = Traverse.Create(__instance).Method("GetConnectedNetworkID").GetValue<int>();
        dispensing = flag;
    }
}
*/





