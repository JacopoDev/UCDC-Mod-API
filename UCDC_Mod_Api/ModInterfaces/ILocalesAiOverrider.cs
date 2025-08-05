using UCDC_Mod_Api.GameInterfaces;
using UCDC_Mod_Api.Models;

namespace UCDC_Mod_Api.ModInterfaces
{
    public interface ILocalesAiOverrider
    {
        public void SetProvider(IAiPromptProvider provider);
    }
}