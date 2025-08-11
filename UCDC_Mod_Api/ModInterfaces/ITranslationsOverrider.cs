using UCDC_Mod_Api.Models.Localization;

namespace UCDC_Mod_Api.ModInterfaces
{
    /// <summary>
    /// Implement this if you want to override english translations <br /><br />
    /// Those translations are loaded at the start of the game
    /// </summary>
    public interface ITranslationsOverrider
    {
        public TranslationInfo GetTranslations();
    }
}