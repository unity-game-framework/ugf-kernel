using System.Collections.Generic;
using UGF.CustomSettings.Runtime;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace UGF.CustomSettings.Editor
{
    public class CustomSettingsProvider<TData> : SettingsProvider where TData : Object, new()
    {
        private AssetSettingsProvider m_provider;
        private readonly CustomSettings<TData> m_settings;

        public CustomSettingsProvider(string path, CustomSettings<TData> settings, SettingsScope scopes, IEnumerable<string> keywords = null) : base(path, scopes, keywords ?? GetSearchKeywordsFromSerializedObject(new SerializedObject(settings.Instance)))
        {
            m_settings = settings;
        }

        public override void OnActivate(string searchContext, VisualElement rootElement)
        {
            EditorApplication.playModeStateChanged += OnEditorApplicationPlayModeStateChanged;

            RecreateEditor();

            base.OnActivate(searchContext, rootElement);
        }

        public override void OnDeactivate()
        {
            EditorApplication.playModeStateChanged -= OnEditorApplicationPlayModeStateChanged;

            ClearEditor();

            base.OnDeactivate();
        }

        public override void OnGUI(string searchContext)
        {
            m_provider?.OnGUI(searchContext);

            base.OnGUI(searchContext);
        }

        public override void OnTitleBarGUI()
        {
            m_provider?.OnTitleBarGUI();

            base.OnTitleBarGUI();
        }

        public override void OnFooterBarGUI()
        {
            m_provider?.OnFooterBarGUI();

            base.OnFooterBarGUI();
        }

        private void OnEditorApplicationPlayModeStateChanged(PlayModeStateChange playModeStateChange)
        {
            RecreateEditor();
        }

        private void ClearEditor()
        {
            if (m_provider != null)
            {
                m_provider.OnDeactivate();
                m_provider = null;
            }
        }

        private void RecreateEditor()
        {
            ClearEditor();

            m_provider = AssetSettingsProvider.CreateProviderFromObject("", m_settings.Instance);
            m_provider.OnActivate(string.Empty, null);
        }
    }
}
