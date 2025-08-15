using UMod;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UCDC_Mod_Api.Models.Scenes
{
    public class SceneData
    {
        public string LocationName;
        public string LocationDescription;
        public string AiContext;
        public IModScene Scene;
        public Texture Preview;
    }
}