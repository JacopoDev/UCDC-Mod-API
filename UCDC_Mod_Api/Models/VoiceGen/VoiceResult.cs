using UnityEngine;

namespace UCDC_Mod_Api.Models.VoiceGen
{
    /// <summary>
    /// Result value from voice-gen ai <br />
    /// Game considers messages successful if code equals 200 (from HttpStatusCode.OK)
    /// </summary>
    public class VoiceResult
    {
        public int Code;
        public string ErrorMessage;
        public AudioClip Voice;
    }
}