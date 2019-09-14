using System;

namespace UGF.Module.Runtime
{
    public class ModuleBuildInfo
    {
        public string BuilderId { get; }
        public string DescriptionId { get { return HasDescription ? m_descriptionId : throw new InvalidOperationException("A description id not specified."); } }
        public bool HasDescription { get { return !string.IsNullOrEmpty(m_descriptionId); } }

        private readonly string m_descriptionId;

        public ModuleBuildInfo(string builderId, string descriptionId = "")
        {
            if (string.IsNullOrEmpty(builderId)) throw new ArgumentNullException(nameof(builderId));

            BuilderId = builderId;
            m_descriptionId = descriptionId;
        }
    }
}
