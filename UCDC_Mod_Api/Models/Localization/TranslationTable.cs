using System.Collections.Generic;
using JetBrains.Annotations;

namespace UCDC_Mod_Api.Models.Localization
{
    public class TranslationTable
    {
        [CanBeNull] public Dictionary<string, string> MainUi;
        [CanBeNull] public Dictionary<string, string> Tutorial;
        [CanBeNull] public Dictionary<string, string> Shop;
        
        [CanBeNull] public Dictionary<string, string> VirusOffenseDialogues;
        [CanBeNull] public Dictionary<string, string> VirusOffenseUi;
    }
}