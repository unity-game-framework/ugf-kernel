using UnityEditor.AddressableAssets.Settings;

namespace UGF.Addressable.Editor.Scheme
{
    public abstract class IncludeGroupSchemeBase : AddressableAssetGroupSchema
    {
        public abstract bool IsIncluded();
    }
}
