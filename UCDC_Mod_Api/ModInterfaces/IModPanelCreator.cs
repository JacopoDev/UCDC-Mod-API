using UnityEngine;

namespace UCDC_Mod_Api.ModInterfaces
{
    /// <summary>
    /// Implement this if you want to add mod settings to phone UI <br /><br />
    /// Those buttons can be accessed in game via Menu->Settings->Mods submenu<br />
    /// </summary>
    public interface IModPanelCreator
    {
        GameObject GetSettingsButton();
        GameObject GetSettingsPanel();
    }
}