namespace UGF.Module.Runtime
{
    public class ModuleBuilderAsset<TBuilder> : ModuleBuilderAsset where TBuilder : class, IModuleBuilder, new()
    {
        public override IModuleBuilder GetBuilder()
        {
            return new TBuilder();
        }
    }
}
