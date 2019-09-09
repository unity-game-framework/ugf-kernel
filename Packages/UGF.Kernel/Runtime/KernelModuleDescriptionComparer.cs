using System.Collections.Generic;

namespace UGF.Kernel.Runtime
{
    internal class KernelModuleDescriptionComparer : IComparer<IKernelModuleDescription>
    {
        public int Compare(IKernelModuleDescription x, IKernelModuleDescription y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (ReferenceEquals(null, y)) return 1;
            if (ReferenceEquals(null, x)) return -1;
            return x.Priority.CompareTo(y.Priority);
        }
    }
}
