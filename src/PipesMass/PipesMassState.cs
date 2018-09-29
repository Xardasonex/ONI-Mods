using ONI_Common.Json;

namespace PipesMass1
{
    class PipesMassState
    {
        public float liquidandgas { get; set; } = 20;
        public float STA { get; set; } = 20;

        public static BaseStateManager<PipesMassState> StateManager
            = new BaseStateManager<PipesMassState>("PipesMass");
    }
}
