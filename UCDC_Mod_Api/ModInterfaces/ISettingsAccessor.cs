using UCDC_Mod_Api.GameInterfaces;

namespace UCDC_Mod_Api.ModInterfaces
{
    /// <summary>
    /// Implement this if you want your script to get access to global mod settings <br /> <br />
    /// To avoid mod conflicts I suggest adding mod name to all mod settings as a prefix, for example saving MagicNumber setting in a Template mod: <br />
    /// <code>
    /// SaveInt("TemplateMod_MagicNumber", 5);
    /// </code>
    /// </summary>
    public interface ISettingsAccessor
    {
        void SetProvider(ISettingsProvider provider);
    }
}