using ONI_Common.Json;

namespace SADState
{
    class SADState
    {
        public float SlimeConsumeKGsPerSecond { get; set; } = 0.6f;

        public static BaseStateManager<SADState> StateManager
            = new BaseStateManager<SADState>("SAD");
    }
}
