using UCDC_Mod_Api.GameInterfaces;
using UnityEngine;

namespace UCDC_Mod_Api.ModInterfaces
{
    public interface ISkinAccessor
    {
        void SkinSetup(ISkinDatabase database);
        void OnSkinSelected(GameObject root);
        void OnSkinDeselected(GameObject root);
    }
}