using UGF.Application.Runtime;
using UnityEngine;

namespace UGF.Kernel.Runtime
{
    public abstract class KernelModuleDescription : IKernelModuleDescription
    {
        [SerializeField] private int m_priority;

        public int Priority { get { return m_priority; } set { m_priority = value; } }

        public abstract void Initialize(IApplication application);
    }
}
