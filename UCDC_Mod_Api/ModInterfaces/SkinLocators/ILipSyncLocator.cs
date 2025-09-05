using UCDC_Mod_Api.Models.Skins;

namespace UCDC_Mod_Api.ModInterfaces.SkinLocators
{
    /// <summary>
    /// Implement this if you want your skin to have lip sync when she speaks <br /><br />
    /// <remarks> It is only used when there is any voice mod enabled and working. <br /> </remarks>
    /// </summary>
    public interface ILipSyncLocator
    {
        public LipSyncData GetLipSyncData();
    }
}