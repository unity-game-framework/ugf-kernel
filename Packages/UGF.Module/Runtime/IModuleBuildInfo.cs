namespace UGF.Module.Runtime
{
    public interface IModuleBuildInfo
    {
        string BuilderId { get; }
        IModuleBuildArguments<string> Arguments { get; }
    }
}
