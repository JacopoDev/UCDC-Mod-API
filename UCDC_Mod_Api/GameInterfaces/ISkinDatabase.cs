using UCDC_Mod_Api.Models;

namespace UCDC_Mod_Api.GameInterfaces
{
    public interface ISkinDatabase
    {
        void Add(SkinInfo skin);
        void Remove(SkinInfo skin);
        void Update(string skinName, SkinInfo newSkin);
        bool Contains(SkinInfo skin);
    }
}