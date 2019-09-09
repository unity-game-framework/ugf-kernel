using System.Collections;
using UGF.Description.Runtime;

namespace UGF.Kernel.Runtime.Description
{
    public interface IDescriptionLoader
    {
        bool InProgress { get; }

        IEnumerator Load();
        IDescription GetResult();
        T GetResult<T>();
    }
}
