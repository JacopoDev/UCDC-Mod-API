using JetBrains.Annotations;

namespace UCDC_Mod_Api.Models
{
    public struct Message
    {
        public string role;
        public string content;
        [CanBeNull] public string imageBase64;
    }
}