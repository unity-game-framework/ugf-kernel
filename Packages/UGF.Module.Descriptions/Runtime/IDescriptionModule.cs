using System.Collections.Generic;
using UGF.Application.Runtime;
using UGF.Description.Runtime;

namespace UGF.Module.Descriptions.Runtime
{
    public interface IDescriptionModule : IApplicationModule
    {
        IDescriptionModuleDescription Description { get; }
        IReadOnlyDictionary<string, IDescription> Descriptions { get; }

        void Add(string name, IDescription description);
        void Remove(string name);
        T GetDescription<T>(string name) where T : IDescription;
        bool TryGetDescription<T>(string name, out T description) where T : IDescription;
    }
}