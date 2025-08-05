using UCDC_Mod_Api.Models;
using UCDC_Mod_Api.Models.TextGen;

namespace UCDC_Mod_Api.ModInterfaces
{
    public interface ITextAiExtraSettings
    {
        public TextAiInfo GetSettings();
    }
}