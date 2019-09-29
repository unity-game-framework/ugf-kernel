using System;

namespace UGF.Module.Runtime
{
    public class ModuleBuildInfo : IModuleBuildInfo
    {
        public bool Active { get; set; } = true;
        public string BuilderId { get; }
        public IModuleBuildArguments<string> Arguments { get; }

        public ModuleBuildInfo(string builderId, IModuleBuildArguments<string> arguments)
        {
            BuilderId = builderId ?? throw new ArgumentNullException(nameof(builderId));
            Arguments = arguments ?? throw new ArgumentNullException(nameof(arguments));
        }
    }
}
