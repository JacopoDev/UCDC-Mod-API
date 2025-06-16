using System.Collections.Generic;
using UMod;

namespace UCDC_Mod_Api.GameInterfaces
{
    /// <summary>
    /// Notice: Interface is implemented by the game classes <br /><br />
    /// Gives access to mod settings <br />
    /// To avoid mod conflicts I suggest adding mod name to all mod settings as a prefix, for example saving MagicNumber setting in a Template mod: <br />
    /// <code>
    /// SaveInt("TemplateMod_MagicNumber", 5);
    /// </code>
    /// </summary>
    public interface ISettingsProvider : IModPersistentData
    {
        Dictionary<string, object> LoadGroupData(string[] values);
        void SaveGroupData(Dictionary<string, object> settings);
    }
}