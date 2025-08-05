using UnityEngine;

namespace UCDC_Mod_Api.Models.Skins
{   
    /// <summary>
    /// Structure for skins to fix the placement for each prop 
    /// </summary>
    public class PropPlacementInfo
    {
        /// <summary>
        /// it has to match the prop definition name so game knows which prop position you are modifying
        /// </summary>
        public string PropName;
        
        public Vector3 Position;
        public Vector3 Rotation;
        public Vector3 Scale;
    }
}