using UCDC_Mod_Api.GameInterfaces;
using UCDC_Mod_Api.Models;

namespace UCDC_Mod_Api.ModInterfaces
{
    /// <summary>
    /// Implement this if you want to change Unity-chan's system prompt <br /><br />
    /// </summary>
    public interface ILocalesAiOverrider
    {
        public void SetProvider(IAiPromptProvider provider);
    }
}