using UCDC_Mod_Api.Models;
using UCDC_Mod_Api.Models.Skins;

namespace UCDC_Mod_Api.GameInterfaces
{
    /// <summary>
    /// Notice: Interface is implemented by the game classes <br /><br />
    /// Adds a way to access in-game skin list 
    /// </summary>
    public interface ISkinDatabaseProvider
    {
        void Add(SkinInfo skin);
        void Remove(SkinInfo skin);
        void Replace(string skinName, SkinInfo newSkin);
        bool Contains(SkinInfo skin);
    }
}