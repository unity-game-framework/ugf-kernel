using System.Collections.Generic;
using UGF.Coroutines.Runtime;
using UGF.Module.Runtime;

namespace UGF.Kernel.Runtime.Loaders
{
    public interface IKernelModuleBuildsLoader
    {
        ICoroutine<IReadOnlyList<IModuleBuild>> Load(IReadOnlyList<IModuleBuildInfo> infos);
    }
}
