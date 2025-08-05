using System;
using System.Collections.Generic;
using UnityEngine;

namespace UCDC_Mod_Api.Models.Skins
{
    [Serializable]
    public class FacialExpressionData
    {
        public SkinnedMeshRenderer expressionMesh;
        public List<BlendShapeMorph> Happy;
        public List<BlendShapeMorph> Sad;
        public List<BlendShapeMorph> Angry;
        public List<BlendShapeMorph> Surprised;
        public List<BlendShapeMorph> Flirty;
    }
}