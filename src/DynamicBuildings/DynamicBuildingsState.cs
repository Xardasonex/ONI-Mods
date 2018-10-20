using ONI_Common.Json;

class DynamicBuildingsState
{
    public float liquidandgas { get; set; } = 10f;
    public float Solid { get; set; } = 20f;
    public float STA { get; set; } = 1000f;
    public float SlimeConsumeKGsPerSecond { get; set; } = 1f;
    public byte SuckInRadius { get; set; } = 2;
    public float GVOP { get; set; } = 2f;
    public float HPGVOP { get; set; } = 10f;
    public bool Fudge { get; set; } = true;
    public float GasRes { get; set; } = 150f;
    public float LiqRes { get; set; } = 5000f;
   /* public bool MetalDupe { get; set; } = true;*/
    public bool RockDupe { get; set; } = true;
    public bool KilnDupe { get; set; } = true;
    public bool GlassDupe { get; set; } = true;
    public float LockerCap { get; set; } = 20000f;
    public float ConLoaderCap { get; set; } = 1000f;
    public float ConUnloaderCap { get; set; } = 100f;
    public bool LockerBase { get; set; } = true;
    public bool BatteryMedBase { get; set; } = true;
    public bool GasResBase { get; set; } = true;
    public bool LiqResBase { get; set; } = true;
    public float Thermos { get; set; } = -14f;


    public static BaseStateManager<DynamicBuildingsState> StateManager= new BaseStateManager<DynamicBuildingsState>("DynamicBuildings");
    }

