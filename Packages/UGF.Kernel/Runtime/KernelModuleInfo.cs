using System;
using UGF.Module.Runtime;
using UnityEngine;

namespace UGF.Kernel.Runtime
{
    [Serializable]
    public class KernelModuleInfo : IModuleBuildInfo
    {
        [SerializeField] private string m_builderId;
        [SerializeField] private KernelModuleInfoArguments m_arguments = new KernelModuleInfoArguments();

        public string BuilderId { get { return m_builderId; } set { m_builderId = value; } }
        public KernelModuleInfoArguments Arguments { get { return m_arguments; } }

        IModuleBuildArguments<string> IModuleBuildInfo.Arguments { get { return Arguments; } }
    }
}
