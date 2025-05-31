using UCDC_Mod_Api.ModInterfaces;

namespace UCDC_Mod_Api.GameInterfaces
{
    public interface IAiApiDatabase
    {
        ITextAiAccessor GetActive();
        void SetApiActive(ITextAiAccessor accessor);
    }
}