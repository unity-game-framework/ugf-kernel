using System;
using System.Collections;
using UGF.Description.Runtime;

namespace UGF.Kernel.Runtime.Description
{
    public abstract class DescriptionLoaderBase<TResult> : IDescriptionLoader where TResult : class, IDescription
    {
        protected TResult Result { get; set; }

        public bool InProgress { get { return m_loadRoutine != null; } }

        private IEnumerator m_loadRoutine;

        public IEnumerator Load()
        {
            m_loadRoutine = OnLoad();

            return WaitForLoad();
        }

        public IDescription GetResult()
        {
            return Result ?? throw new InvalidOperationException("Description not yet loaded.");
        }

        public T GetResult<T>()
        {
            return (T)GetResult();
        }

        protected abstract IEnumerator OnLoad();

        private IEnumerator WaitForLoad()
        {
            yield return OnLoad();

            m_loadRoutine = null;
        }
    }
}
