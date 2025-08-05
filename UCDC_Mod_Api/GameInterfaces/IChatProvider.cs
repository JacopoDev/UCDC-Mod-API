using UCDC_Mod_Api.Models;
using UCDC_Mod_Api.Models.TextGen;
using UCDC_Mod_Api.ModInterfaces;

namespace UCDC_Mod_Api.GameInterfaces
{
    /// <summary>
    /// Notice: Interface is implemented by the game classes <br /><br />
    /// Gives current list of messages to be processed in text-gen API (chat messages, emotion analysis, user facts)
    /// </summary>
    public interface IChatProvider
    {
        Chat GetChat();
    }
}