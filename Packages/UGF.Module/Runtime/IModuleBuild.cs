using UGF.Description.Runtime;

namespace UGF.Module.Runtime
{
    public interface IModuleBuild
    {
        IModuleBuilder Builder { get; }
        IModuleBuildArguments<IDescription> Arguments { get; }
    }
}
