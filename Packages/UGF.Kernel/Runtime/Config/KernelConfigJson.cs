using System;
using UnityEngine;

namespace UGF.Kernel.Runtime.Config
{
    [Serializable]
    public class KernelConfigJson
    {
        [SerializeField] private KernelConfig config = new KernelConfig();

        public KernelConfig Config { get { return config; } set { config = value; } }
    }
}
