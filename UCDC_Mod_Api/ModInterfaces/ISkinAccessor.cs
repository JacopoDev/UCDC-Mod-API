using UCDC_Mod_Api.GameInterfaces;
using UnityEngine;

namespace UCDC_Mod_Api.ModInterfaces
{
    /// <summary>
    /// Implement this if you want to add new skin to the game
    /// </summary>
    public interface ISkinAccessor
    {
        void GetDatabase(ISkinDatabaseProvider databaseProvider);
    }
}