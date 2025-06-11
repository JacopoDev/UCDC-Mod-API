using UCDC_Mod_Api.ModInterfaces;

namespace UCDC_Mod_Api.GameInterfaces
{
    public interface IAiApiDatabase
    {
        ITextAiAccessor GetActiveTextAccessor();
        void SetActiveTextAccessor(ITextAiAccessor accessor);
        IVoiceAiAccessor GetActiveVoiceAccessor();
        void SetActiveVoiceAccessor(IVoiceAiAccessor accessor);
    }
}