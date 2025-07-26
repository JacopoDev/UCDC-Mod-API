using UnityEngine;

namespace UCDC_Mod_Api.ModInterfaces.SkinLocators
{
    /// <summary>
    /// Implement this and add as monoBehaviour component to root skin object to add support to blinking managed by game <br /><br />
    /// </summary>
    public interface IBlinkLocator
    {
        // Return skinned mesh for face/left eye
        public SkinnedMeshRenderer GetLeftEye();
        // Return skinned mesh for face/right eye
        public SkinnedMeshRenderer GetRightEye();

        public int GetEyeCloseBlendIdLeft();
        public int GetEyeCloseBlendIdRight();

        public float GetEyeOpenBlendValue();
        public float GetEyeCloseBlendValue();
    }
}