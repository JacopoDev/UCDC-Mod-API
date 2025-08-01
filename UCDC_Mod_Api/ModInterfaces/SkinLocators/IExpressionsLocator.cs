using UCDC_Mod_Api.Models;

namespace UCDC_Mod_Api.ModInterfaces.SkinLocators
{
    /// <summary>
    /// Implement this and add as monoBehaviour component to root skin object to add support to basic facial expressions managed by game <br /><br />
    /// </summary>
    public interface IExpressionsLocator
    {
        public FacialExpressionData GetExpressionData();
    }
}