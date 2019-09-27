using System.Collections.Generic;

namespace UGF.Assets.Runtime
{
    public interface IAssetsCatalog
    {
        IReadOnlyDictionary<string, IAssetInfo> Infos { get; }
    }

    public interface IAssetInfo
    {
        string Guid { get; }
        string SourceName { get; }
    }

    public interface IAssetResourceInfo : IAssetInfo
    {
        string Path { get; }
    }

    public interface IAssetBundleInfo : IAssetInfo
    {
        string Path { get; }
        string BundleName { get; }
    }
}
