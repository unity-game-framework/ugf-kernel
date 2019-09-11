using System.Collections.Generic;
using UGF.Description.Runtime;
using UGF.Modules.Runtime;

namespace UGF.Kernel.Runtime
{
    public interface IKernelConfig : IDescription
    {
        string Name { get; }
        IReadOnlyList<ModuleInfo> Modules { get; }
    }
}
