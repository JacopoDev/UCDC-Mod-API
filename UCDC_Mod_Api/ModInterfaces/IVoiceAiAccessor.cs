using System;
using UCDC_Mod_Api.GameInterfaces;
using UCDC_Mod_Api.Models;

namespace UCDC_Mod_Api.ModInterfaces
{
    public interface IVoiceAiAccessor
    {
        void SetDatabase(IAiApiDatabase database);
        int GenerateMessage(string text, Action<VoiceResult> finishedAction);
    }
}