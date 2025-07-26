using System.Collections.Generic;
using UCDC_Mod_Api.Models;
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
    /// <remarks>The component should hold Transforms where each prop object should be placed. <br />
    /// Transforms should be empty objects, you can rotate and scale them so props are properly placed on skin <br />
    /// You can add root position overrides in ITextAiAccessor.<see cref="IPropsLocator.GetPropRootOverrides"/> to move, rotate and rescale so prop is properly attached to the skin </remarks>
    /// </summary>
    public interface IPropsLocator
    {
        public Dictionary<EPropsLocation, Transform> GetPropsLocations();
        public List<PropPlacementInfo> GetPropRootOverrides();
    }
}