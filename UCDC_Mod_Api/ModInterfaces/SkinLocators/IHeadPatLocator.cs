using UnityEngine;

namespace UCDC_Mod_Api.ModInterfaces.SkinLocators
{
    /// <summary>
    /// Implement this and add as monoBehaviour component  to root skin object to add support to giving head pats! <br /><br />
    /// The component should hold a transform where an object that allows headpatting should be placed and head transform. <br />
    /// </summary>
    public interface IHeadPatLocator
    {
        public Transform GetHeadPatColliderSpot();
        public Transform GetHeadTransform();
        public Transform GetNeckTransform();
        public Transform GetPettingHandPlacement();
    }
}