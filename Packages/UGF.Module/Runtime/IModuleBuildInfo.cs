namespace UGF.Module.Runtime
{
    public interface IModuleBuildInfo
    {
        bool Active { get; }
        string BuilderId { get; }
        IModuleBuildArguments<string> Arguments { get; }
    }
}
