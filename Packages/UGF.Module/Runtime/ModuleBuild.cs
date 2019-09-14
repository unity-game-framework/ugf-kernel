using System;

namespace UGF.Module.Runtime
{
    public struct ModuleBuild
    {
        public IModuleBuilder Builder { get; }
        public IModuleDescription Description { get { return m_description ?? throw new InvalidOperationException("A description not specified."); } }
        public bool HasDescription { get { return m_description != null; } }

        private readonly IModuleDescription m_description;

        public ModuleBuild(IModuleBuilder builder, IModuleDescription description = null)
        {
            Builder = builder ?? throw new ArgumentNullException(nameof(builder));
            m_description = description;
        }
    }
}
