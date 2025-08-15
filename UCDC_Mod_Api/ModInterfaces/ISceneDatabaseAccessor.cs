using UCDC_Mod_Api.GameInterfaces;

namespace UCDC_Mod_Api.ModInterfaces
{
    /// <summary>
    /// Implement this if you want to add new sceneries to the game <br /><br />
    /// Create your own scene, and then add it by calling AddOutdoorScene or OverrideHomeScene of the provider
    /// </summary>
    public interface ISceneDatabaseAccessor
    {
        public void SetProvider(ISceneDatabaseProvider provider);
    }
}