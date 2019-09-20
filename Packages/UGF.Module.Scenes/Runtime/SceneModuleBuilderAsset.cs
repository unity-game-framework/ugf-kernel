using UGF.Application.Runtime;
using UGF.Description.Runtime;
using UGF.Module.Coroutines.Runtime;
using UGF.Module.Runtime;

namespace UGF.Module.Scenes.Runtime
{
    public class SceneModuleBuilderAsset : ModuleBuilderAsset<ISceneModule>
    {
        protected override IApplicationModule OnBuild(IApplication application, IModuleBuildArguments<IDescription> arguments)
        {
            var coroutineModule = application.GetModule<ICoroutineModule>();

            return new SceneModule(coroutineModule);
        }
    }
}
