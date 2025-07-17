using System.Collections.Generic;
using UnityEngine;

namespace UCDC_Mod_Api.ModInterfaces.SkinLocators
{
    /// <summary>
    /// Implement this and add as monoBehaviour component to root skin object to add support to ragdolling character <br /><br />
    /// The component should hold Rigidbodies to turn on during ragdoll state. <br />
    /// </summary>
    public interface IRagDollLocator
    {
        public List<Rigidbody> GetBodyParts();
        public Transform GetHip();
    }
}