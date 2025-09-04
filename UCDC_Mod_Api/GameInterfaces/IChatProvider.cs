using JetBrains.Annotations;
using UCDC_Mod_Api.Models;
using UCDC_Mod_Api.Models.TextGen;
using UCDC_Mod_Api.ModInterfaces;

namespace UCDC_Mod_Api.GameInterfaces
{
    /// <summary>
    /// Notice: Interface is implemented by the game classes <br /><br />
    /// Gives current list of messages to be processed in text-gen API (chat messages, emotion analysis, user facts) <br />
    /// <see cref="IChatProvider.GetResponseFormat"/> is used only for AI that has support for structured outputs, serialized in json with schema
    /// </summary>
    public interface IChatProvider
    {
        Chat GetChat();
        [CanBeNull] string GetResponseFormat();
    }
}