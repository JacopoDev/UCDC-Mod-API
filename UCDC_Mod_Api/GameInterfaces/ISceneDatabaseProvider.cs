using UCDC_Mod_Api.Models.Scenes;

namespace UCDC_Mod_Api.GameInterfaces
{
    public interface ISceneDatabaseProvider
    {
        public void AddOutdoorScene(SceneData data);
        public void OverrideHomeScene(SceneData data);
    }
}