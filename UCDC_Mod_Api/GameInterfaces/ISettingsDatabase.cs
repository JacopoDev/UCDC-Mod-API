using System.Collections.Generic;
using UMod;

namespace UCDC_Mod_Api.GameInterfaces
{
    public interface ISettingsDatabase : IModPersistentData
    {
        Dictionary<string, object> LoadGroupData(string[] values);
        void SaveGroupData(Dictionary<string, object> settings);
    }
}