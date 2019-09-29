using System;
using System.Collections.Generic;
using UGF.Coroutines.Runtime;
using UGF.Kernel.Runtime.Loaders;
using UGF.Module.Addressable.Runtime.Coroutines;
using UGF.Module.Runtime;

namespace UGF.Module.Addressable.Runtime.Loaders
{
    public class KernelModuleBuildsAddressableLoader : KernelModuleBuildsLoader
    {
        public override ICoroutine<IReadOnlyList<IModuleBuild>> Load(IReadOnlyList<IModuleBuildInfo> infos)
        {
            if (infos == null) throw new ArgumentNullException(nameof(infos));

            return new LoadModuleBuildsAddressableCoroutine(infos);
        }
    }
}
