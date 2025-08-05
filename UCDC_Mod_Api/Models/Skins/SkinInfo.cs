using System;
using JetBrains.Annotations;
using UnityEngine;

namespace UCDC_Mod_Api.Models.Skins
{
    public class SkinInfo
    {
        [CanBeNull] public string CharacterName;
        [CanBeNull] public string AltCharacterName;
        public string SkinName;
        public string Description;
        public Sprite Preview;
        public GameObject Prefab;
        public Avatar AnimationAvatar;

        public Action OnSkinSelected;
    }
}