using ONI_Common.Json;

    class DynamicBuildingsState
{
        public float liquidandgas { get; set; } = 20;
        public float STA { get; set; } = 1000;
        public float SlimeConsumeKGsPerSecond { get; set; } = 1f;
        public byte SuckInRadius { get; set; } = 2;

    public static BaseStateManager<DynamicBuildingsState> StateManager
            = new BaseStateManager<DynamicBuildingsState>("DynamicBuildings");
    }

