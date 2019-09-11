using System.Collections;
using System.Collections.Generic;

namespace UGF.Modules.Runtime
{
    public interface IModuleBuildLoader
    {
        IEnumerator LoadAsync(ICollection<ModuleBuild> builds, IReadOnlyList<ModuleInfo> infos);
    }
}
