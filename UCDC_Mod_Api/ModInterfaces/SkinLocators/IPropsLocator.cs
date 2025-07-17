using System.Collections.Generic;
using UnityEngine;

namespace UCDC_Mod_Api.ModInterfaces.SkinLocators
{
    public enum EPropsLocation
    {
        TopHead,
        LeftHand,
        RightHand,
    }
    
    /// <summary>
    /// Implement this and add as monoBehaviour component to root skin object to add support to dynamic props adding <br /><br />
    /// The component should hold Transforms where each prop object should be placed. <br />
    /// Transforms should be empty objects, you can rotate and scale them so props are properly placed on skin
    /// </summary>
    public interface IPropsLocator
    {
        public Dictionary<EPropsLocation, Transform> GetPropsLocations();
    }
}