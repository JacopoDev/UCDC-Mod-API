using JetBrains.Annotations;

namespace UCDC_Mod_Api.Models
{
    /// <summary>
    /// Basic chat structure <br /><br />
    /// Message.<see cref="Message.role"/> can take values of: "User", "Assistant", "System"
    /// </summary>
    public struct Message
    {
        public string role;
        public string content;
        [CanBeNull] public string imageBase64;
    }
}