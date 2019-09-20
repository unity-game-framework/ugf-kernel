using System;
using System.Collections;
using UGF.Application.Runtime;
using UGF.Coroutines.Runtime.Unity;
using UGF.Initialize.Runtime;

namespace UGF.Module.Coroutines.Runtime
{
    public class CoroutineModule : ApplicationModuleBase, ICoroutineModule
    {
        private CoroutineExecuterUnity m_executer;

        protected override void OnInitialize()
        {
            base.OnInitialize();

            m_executer = new CoroutineExecuterUnity(false, "CoroutineModuleExecuter");
        }

        protected override void OnUninitialize()
        {
            base.OnUninitialize();

            m_executer.Dispose();
            m_executer = null;
        }

        public void Start(IEnumerator routine)
        {
            if (routine == null) throw new ArgumentNullException(nameof(routine));
            if (m_executer == null) throw new InitializeStateException("Module not initialized.");

            m_executer.Start(routine);
        }

        public void Stop(IEnumerator routine)
        {
            if (routine == null) throw new ArgumentNullException(nameof(routine));
            if (m_executer == null) throw new InitializeStateException("Module not initialized.");

            m_executer.Stop(routine);
        }
    }
}
