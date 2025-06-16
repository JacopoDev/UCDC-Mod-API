using System;
using UCDC_Mod_Api.GameInterfaces;
using UCDC_Mod_Api.Models;

namespace UCDC_Mod_Api.ModInterfaces
{
    /// <summary>
    /// Implement this if you want to add new voice-gen ai API <br /><br />
    /// <remarks>Note that IVoiceAiAccessor.<see cref="IVoiceAiAccessor.GenerateMessage"/> is called in game as asynchronous operation, as a consequence there may be difficulties calling some UnityEngine methods on this thread (can be fixed with i.e. using thread dispatcher)<br /></remarks>
    /// </summary>
    public interface IVoiceAiAccessor
    {
        void SetProvider(IAiApiProvider provider);
        int GenerateMessage(string text, Action<VoiceResult> finishedAction);
    }
}