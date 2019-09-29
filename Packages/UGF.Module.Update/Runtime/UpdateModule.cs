using UGF.Application.Runtime;
using UGF.Module.Update.Runtime.Handlers;
using UGF.Update.Runtime;
using UnityEngine.LowLevel;
using UnityEngine.Profiling;
using PlayerLoops = UnityEngine.PlayerLoop;

namespace UGF.Module.Update.Runtime
{
    public class UpdateModule : ApplicationModuleBase, IUpdateModule
    {
        public IUpdateCollection<IPreUpdateHandler> PreUpdate { get { return m_preUpdate; } }
        public IUpdateCollection<IUpdateHandler> Update { get { return m_update; } }
        public IUpdateCollection<IFixedUpdateHandler> FixedUpdate { get { return m_fixedUpdate; } }
        public IUpdateCollection<IPostLateUpdateHandler> PostLateUpdate { get { return m_postLateUpdate; } }

        private readonly UpdateSetHandler<IPreUpdateHandler> m_preUpdate = new UpdateSetHandler<IPreUpdateHandler>(handler => handler.PreUpdate());
        private readonly UpdateSet<IUpdateHandler> m_update = new UpdateSet<IUpdateHandler>();
        private readonly UpdateSetHandler<IFixedUpdateHandler> m_fixedUpdate = new UpdateSetHandler<IFixedUpdateHandler>(handler => handler.OnFixedUpdate());
        private readonly UpdateSetHandler<IPostLateUpdateHandler> m_postLateUpdate = new UpdateSetHandler<IPostLateUpdateHandler>(handler => handler.OnPostLateUpdate());

        protected override void OnInitialize()
        {
            base.OnInitialize();

            PlayerLoopSystem playerLoop = PlayerLoop.GetDefaultPlayerLoop();

            UpdateUtility.TryAddUpdateFunction(playerLoop, typeof(PlayerLoops.PreUpdate), OnPreUpdate);
            UpdateUtility.TryAddUpdateFunction(playerLoop, typeof(PlayerLoops.Update), OnUpdate);
            UpdateUtility.TryAddUpdateFunction(playerLoop, typeof(PlayerLoops.FixedUpdate), OnFixedUpdate);
            UpdateUtility.TryAddUpdateFunction(playerLoop, typeof(PlayerLoops.PostLateUpdate), OnPostLateUpdate);

            PlayerLoop.SetPlayerLoop(playerLoop);
        }

        protected override void OnUninitialize()
        {
            base.OnUninitialize();

            PlayerLoop.SetPlayerLoop(PlayerLoop.GetDefaultPlayerLoop());
        }

        private void OnPreUpdate()
        {
            Profiler.BeginSample("UpdateModule.OnPreUpdate");

            m_preUpdate.ApplyQueueAndUpdate();

            Profiler.EndSample();
        }

        private void OnUpdate()
        {
            Profiler.BeginSample("UpdateModule.OnUpdate");

            m_update.ApplyQueueAndUpdate();

            Profiler.EndSample();
        }

        private void OnFixedUpdate()
        {
            Profiler.BeginSample("UpdateModule.OnFixedUpdate");

            m_fixedUpdate.ApplyQueueAndUpdate();

            Profiler.EndSample();
        }

        private void OnPostLateUpdate()
        {
            Profiler.BeginSample("UpdateModule.OnPostLateUpdate");

            m_postLateUpdate.ApplyQueueAndUpdate();

            Profiler.EndSample();
        }
    }
}
