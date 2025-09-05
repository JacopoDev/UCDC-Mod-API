using System;
using UnityEngine;

namespace UCDC_Mod_Api.Models.Skins
{
    [Serializable]
    public class LipSyncData
    {
        public SkinnedMeshRenderer lipSyncMesh;
        public BlendShapeMorph a;
        public BlendShapeMorph u;
        public BlendShapeMorph i;
        public BlendShapeMorph e;
        public BlendShapeMorph o;
        public BlendShapeMorph n;
        public BlendShapeMorph none;
    }
}