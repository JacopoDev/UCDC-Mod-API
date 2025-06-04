using UCDC_Mod_Api.GameInterfaces;

namespace UCDC_Mod_Api.ModInterfaces
{
    public interface ISettingsAccessor
    {
        void SetDatabase(ISettingsDatabase database);
    }
}