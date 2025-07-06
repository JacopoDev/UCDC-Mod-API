namespace UCDC_Mod_Api.Models
{
    /// <summary>
    /// Stores configuration flags for text generation AI behavior and capabilities.
    /// Without it the game assumes all false
    /// </summary>
    public class TextAiInfo
    {
        /// <summary>
        /// Indicates whether the AI supports interpreting images as input.
        /// Images are sent in base64 format
        /// </summary>
        public bool IsImageReading;
        
        /// <summary>
        /// Set to true if the text generation is quick (say generating a basic sentence in seconds). 
        /// Will use text-generation in game moments where timing is important (character asking for quick help).
        /// Otherwise the game will use hard-coded phrases in those moments.
        /// </summary>
        public bool IsQuick;
        
        /// <summary>
        /// Indicates support for multiple languages in both input and output. If true the game will send system prompt
        /// based on game language setting, otherwise always English
        /// </summary>
        public bool IsMultiLanguage;
        
        /// <summary>
        /// Enables streaming output, where responses are returned progressively as they are generated.
        /// </summary>
        public bool IsStreaming; 
        
        /// <summary>
        /// Indicates support for structured outputs for fixed JSON format,
        /// If it is supported it may speed up conversations (one generation instead of 3).
        /// </summary>
        public bool IsStructured;
    }
}