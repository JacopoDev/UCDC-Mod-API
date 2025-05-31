using System;
using UCDC_Mod_Api.GameInterfaces;
using UCDC_Mod_Api.Models;
using UnityEngine;

namespace UCDC_Mod_Api.ModInterfaces
{
    public interface ITextAiAccessor
    {
        void GetDatabase(IAiApiDatabase database);
        int GenerateMessage(ITextAiProcessor aiProcessor, Action<Result> finishedAction);
    }
}