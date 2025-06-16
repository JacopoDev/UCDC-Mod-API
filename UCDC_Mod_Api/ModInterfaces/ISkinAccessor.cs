using UCDC_Mod_Api.GameInterfaces;
using UnityEngine;

namespace UCDC_Mod_Api.ModInterfaces
{
    /// <summary>
    /// Implement this if you want to add new skin to the game (no support yet!)
    /// </summary>
    public interface ISkinAccessor
    {
        void SkinSetup(ISkinDatabaseProvider databaseProvider);
        void OnSkinSelected(GameObject root);
        void OnSkinDeselected(GameObject root);
    }
}