namespace UCDC_Mod_Api.Models
{
    /// <summary>
    /// Result value from text-gen ai <br />
    /// Game considers messages successful if code equals 200 (from HttpStatusCode.OK)
    /// </summary>
    public class TextResult
    {
        public int Code;
        public string ErrorMessage;
        public Message Message;
    }
}