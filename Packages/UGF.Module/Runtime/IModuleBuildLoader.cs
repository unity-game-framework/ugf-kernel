using System.Collections;
using System.Collections.Generic;

namespace UGF.Module.Runtime
{
    public interface IModuleBuildLoader
    {
        IEnumerator LoadAsync(ICollection<IModuleBuild> builds, IReadOnlyList<IModuleBuildInfo> infos);
    }
}
