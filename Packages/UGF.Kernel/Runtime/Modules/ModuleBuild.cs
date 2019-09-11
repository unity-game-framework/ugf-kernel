namespace UGF.Kernel.Runtime.Modules
{
    public struct ModuleBuild
    {
        public IModuleBuilder Builder { get; }
        public IModuleDescription Description { get; }

        public ModuleBuild(IModuleBuilder builder, IModuleDescription description)
        {
            Builder = builder;
            Description = description;
        }
    }
}
