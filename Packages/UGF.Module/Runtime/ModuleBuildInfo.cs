namespace UGF.Module.Runtime
{
    public class ModuleBuildInfo : IModuleBuildInfo
    {
        public string BuilderId { get; }
        public IModuleBuildArguments<string> Arguments { get; }

        public ModuleBuildInfo(string builderId, IModuleBuildArguments<string> arguments)
        {
            BuilderId = builderId;
            Arguments = arguments;
        }
    }
}
