using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

namespace UGF.Kernel.Runtime.Config
{
    public class KernelConfigJsonLoader : IKernelConfigLoader
    {
        public string Path { get; }

        private IKernelConfig m_result;

        public KernelConfigJsonLoader(string path)
        {
            Path = path;
        }

        public IEnumerator Load()
        {
            using (UnityWebRequest request = UnityWebRequest.Get(Path))
            {
                yield return request.SendWebRequest();

                if (!string.IsNullOrEmpty(request.error))
                {
                    throw new Exception($"Request error: {request.error}");
                }

                string text = request.downloadHandler.text;
                var config = JsonUtility.FromJson<KernelConfigJson>(text);

                m_result = config.Config;
            }
        }

        public IKernelConfig GetResult()
        {
            return m_result ?? throw new InvalidOperationException("The config not loaded.");
        }
    }
}
