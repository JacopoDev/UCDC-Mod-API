using UnityEngine;

namespace UCDC_Mod_Api.ModInterfaces
{
    /// <summary>
    /// Implement this if you want to instantiate a GameObject during mod initialization <br /><br />
    /// Game looks for any script implementing it and initializes one instance of the provided object<br />
    /// May be useful for some kind of managers, permanent overlays<br />
    /// </summary>
    public interface ICreatedOnLoad
    {
        GameObject GetPrefab();
    }
}