using System.Collections.Generic;
using UGF.Description.Runtime;

namespace UGF.Kernel.Runtime
{
    public interface IKernelConfig : IDescription
    {
        string Name { get; }
        IEnumerable<IKernelModuleConfig> Modules { get; }
    }
}
