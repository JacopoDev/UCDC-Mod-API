using System;
using UCDC_Mod_Api.GameInterfaces;
using UCDC_Mod_Api.Models;
using UCDC_Mod_Api.Models.TextGen;
using UnityEngine;

namespace UCDC_Mod_Api.ModInterfaces
{
    /// <summary>
    /// Implement this if you want to add new text-gen ai API <br /><br />
    /// <remarks>Note that ITextAiAccessor.<see cref="ITextAiAccessor.GenerateMessage"/> is called in game as asynchronous operation, as a consequence there may be difficulties calling some UnityEngine methods on this thread (can be fixed with i.e. using thread dispatcher)<br /></remarks>
    /// </summary>
    public interface ITextAiAccessor
    {
        void SetProvider(IAiApiProvider provider);
        int GenerateMessage(IChatProvider aiProcessor, Action<TextResult> finishedAction);
    }
}