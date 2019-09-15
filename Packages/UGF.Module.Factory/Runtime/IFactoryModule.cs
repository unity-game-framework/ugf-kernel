using UGF.Application.Runtime;
using UGF.Factory.Runtime;

namespace UGF.Module.Factory.Runtime
{
    public interface IFactoryModule : IApplicationModule
    {
        IFactoryProvider Provider { get; }
    }
}
