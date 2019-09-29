using System;
using UGF.Description.Runtime;

namespace UGF.Module.Runtime
{
    public class ModuleBuild : IModuleBuild
    {
        public IModuleBuilder Builder { get; }
        public IModuleBuildArguments<IDescription> Arguments { get; }

        public ModuleBuild(IModuleBuilder builder, IModuleBuildArguments<IDescription> arguments)
        {
            Builder = builder ?? throw new ArgumentNullException(nameof(builder));
            Arguments = arguments ?? throw new ArgumentNullException(nameof(arguments));
        }
    }
}
