using UGF.Addressable.Editor.Scheme;
using UnityEditor.AddressableAssets.Build.DataBuilders;
using UnityEditor.AddressableAssets.Settings;
using UnityEngine;

namespace UGF.Addressable.Editor.Build
{
    [CreateAssetMenu(fileName = "BuildScriptWithIncludes.asset", menuName = "Addressable Assets/Data Builders/Packed Mode Includes")]
    public class BuildScriptWithIncludes : BuildScriptPackedMode
    {
        public override string Name { get; } = "Packed Mode Includes";

        protected override string ProcessGroup(AddressableAssetGroup assetGroup, AddressableAssetsBuildContext aaContext)
        {
            bool include = IsIncluded(assetGroup);

            return include ? base.ProcessGroup(assetGroup, aaContext) : string.Empty;
        }

        protected virtual bool IsIncluded(AddressableAssetGroup assetGroup)
        {
            for (int i = 0; i < assetGroup.Schemas.Count; i++)
            {
                if (assetGroup.Schemas[i] is IncludeGroupSchemeBase scheme)
                {
                    if (!scheme.IsIncluded())
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
