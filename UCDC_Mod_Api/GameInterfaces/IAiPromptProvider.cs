using UCDC_Mod_Api.Models;
using UCDC_Mod_Api.Models.Localization;
using UCDC_Mod_Api.ModInterfaces;
using UMod;

namespace UCDC_Mod_Api.GameInterfaces
{
    public interface IAiPromptProvider
    {
        public void OverridePrompt(IModHost source, AiPromptTexts promptData);
    }
}