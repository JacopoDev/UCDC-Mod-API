using System.Collections.Generic;
using JetBrains.Annotations;

namespace UCDC_Mod_Api.Models.Localization
{
    public enum EAiPrompt
    {
        Base,
    
        Greeting,
        KnowledgeTitle,
        KnownFactTitle,
        TimeTitle,
        EmotionAnalysisTitle,
        TimePassedTitle,
        LeftWithoutSayTitle,
        LeftBigTimespanTitle,
    
        DesktopAppsMessage,
        JokeMessage,
        DateEventMessage,
        ThrowMessage,
    
        DataDetectionPrompt,
        EmotionDetectionPrompt,
        GameStreamPrompt,
    
        LoreDadTags,
        LoreDadValues,
    
        LoreMomTags,
        LoreMomValues,
    
        LoreDreamsTags,
        LoreDreamsValues,
    
        LoreFoodTags,
        LoreFoodValues,
    
        LoreFriendsTags,
        LoreFriendsValues,
    
        LoreYukoTags,
        LoreYukoValues,
    
        LoreMisakiTags,
        LoreMisakiValues,
    
        Match3Win,
        Match3Lose,
    
        TicTacToeWin,
        TicTacToeLose,
    
        AngryPrompt,
        FlirtyPrompt,
        HappyPrompt,
        NeutralEmotionPrompt,
        SadPrompt,
        TiredPrompt,
    
        BulliedRelPrompt,
        CooperativeRelPrompt,
        DislikeRelPrompt,
        FriendRelPrompt,
        LoveRelPrompt,
        NeutralRelPrompt,
        PreFriendRelPrompt,
        PreLoveRelPrompt,
    
        DesktopPrompt,
        RoomPrompt
    }
    public class AiPromptTexts
    {
        public Dictionary<EAiPrompt, string> AiPrompts;
    }
}