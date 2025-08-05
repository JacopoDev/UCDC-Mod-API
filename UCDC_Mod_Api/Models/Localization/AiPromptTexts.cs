using JetBrains.Annotations;

namespace UCDC_Mod_Api.Models.Localization
{
    public class AiPromptTexts
    {
        [CanBeNull] public string Base;

        [CanBeNull] public string Greeting;
        [CanBeNull] public string KnowledgeTitle;
        [CanBeNull] public string KnownFactTitle;
        [CanBeNull] public string TimeTitle;
        [CanBeNull] public string EmotionAnalysisTitle;
        [CanBeNull] public string TimePassedTitle;
        [CanBeNull] public string LeftWithoutSayTitle;
        [CanBeNull] public string LeftBigTimespanTitle;
        
        [CanBeNull] public string DesktopAppsMessage;
        [CanBeNull] public string JokeMessage;
        [CanBeNull] public string DateEventMessage;
        [CanBeNull] public string ThrowMessage;
        
        [CanBeNull] public string DataDetectionPrompt;
        [CanBeNull] public string EmotionDetectionPrompt;
        [CanBeNull] public string GameStreamPrompt;
        
        [CanBeNull] public string LoreDadTags;
        [CanBeNull] public string LoreDadValues;
            
        [CanBeNull] public string LoreMomTags;
        [CanBeNull] public string LoreMomValues;
            
        [CanBeNull] public string LoreDreamsTags;
        [CanBeNull] public string LoreDreamsValues;
            
        [CanBeNull] public string LoreFoodTags;
        [CanBeNull] public string LoreFoodValues;
            
        [CanBeNull] public string LoreFriendsTags;
        [CanBeNull] public string LoreFriendsValues;
            
        [CanBeNull] public string LoreYukoTags;
        [CanBeNull] public string LoreYukoValues;
            
        [CanBeNull] public string LoreMisakiTags;
        [CanBeNull] public string LoreMisakiValues;
            
        [CanBeNull] public string Match3Win;
        [CanBeNull] public string Match3Lose;
            
        [CanBeNull] public string TicTacToeWin;
        [CanBeNull] public string TicTacToeLose;
        
        [CanBeNull] public string AngryPrompt;
        [CanBeNull] public string FlirtyPrompt;
        [CanBeNull] public string HappyPrompt;
        [CanBeNull] public string NeutralEmotionPrompt;
        [CanBeNull] public string SadPrompt;
        [CanBeNull] public string TiredPrompt;
        
        [CanBeNull] public string BulliedRelPrompt;
        [CanBeNull] public string CooperativeRelPrompt;
        [CanBeNull] public string DislikeRelPrompt;
        [CanBeNull] public string FriendRelPrompt;
        [CanBeNull] public string LoveRelPrompt;
        [CanBeNull] public string NeutralRelPrompt;
        [CanBeNull] public string PreFriendRelPrompt;
        [CanBeNull] public string PreLoveRelPrompt;
        
        [CanBeNull] public string DesktopPrompt;
        [CanBeNull] public string RoomPrompt;
    }
}