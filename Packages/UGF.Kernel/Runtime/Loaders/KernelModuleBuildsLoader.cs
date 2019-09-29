using System.Collections.Generic;
using UGF.Coroutines.Runtime;
using UGF.Module.Runtime;
using UnityEngine;

namespace UGF.Kernel.Runtime.Loaders
{
    public abstract class KernelModuleBuildsLoader : MonoBehaviour, IKernelModuleBuildsLoader
    {
        public abstract ICoroutine<IReadOnlyList<IModuleBuild>> Load(IReadOnlyList<IModuleBuildInfo> infos);
    }
}
