using System;
using System.Collections.Generic;
using UGF.Coroutines.Runtime;
using UGF.Kernel.Runtime.Coroutines;
using UGF.Module.Runtime;

namespace UGF.Kernel.Runtime.Loaders
{
    public class KernelModuleBuildsLoaderResources : KernelModuleBuildsLoader
    {
        public override ICoroutine<IReadOnlyList<IModuleBuild>> Load(IReadOnlyList<IModuleBuildInfo> infos)
        {
            if (infos == null) throw new ArgumentNullException(nameof(infos));

            return new LoadBuildsResourcesCoroutine(infos);
        }
    }
}
