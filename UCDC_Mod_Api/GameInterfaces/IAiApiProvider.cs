using UCDC_Mod_Api.ModInterfaces;

namespace UCDC_Mod_Api.GameInterfaces
{
    /// <summary>
    /// Notice: Interface is implemented by the game classes<br /><br />
    /// Injected game object in <see cref="ITextAiAccessor"/> and  <see cref="IVoiceAiAccessor"/> during mod load
    /// </summary>
    public interface IAiApiProvider
    {
        ITextAiAccessor GetActiveTextAccessor();
        void SetActiveTextAccessor(ITextAiAccessor accessor);
        IVoiceAiAccessor GetActiveVoiceAccessor();
        void SetActiveVoiceAccessor(IVoiceAiAccessor accessor);
    }
}