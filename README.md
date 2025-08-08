# UCDC Mod API

The **UCDC Mod API** is a C# library used in **Unity-Chan: Desktop Companion** that defines how mods communicate with the game.  
It is used to enable modders access to some parts of the game to be overriden or to extend existing functionalities.

UCDC Mod API is a part of UCDC Mod Toolset - **if you want to create mods, use the whole toolset and use this repository as script reference**

You can find UCDC Mod Tolset here:
👉 [UCDC Mod Toolset](https://github.com/JacopoDev/UCDC-Mod-Toolset)

This API does **not** contain game logic - it’s a contract between your mod and the game.  
You implement certain interfaces in your mod, and the game calls them at runtime to exchange data and functionality.

---

## Overview

The UCDC Mod API has several interfaces that allow you to:
- **Override text and voice message generation** 
- **Replace character** via skins, props, facial expressions and AI system prompt
- **Add mod UI** with your own panels and settings
- **Persist mod data** between sessions

It works by defining:
- **Game-to-Mod interfaces**: Implemented by the game, called by your mod to interact with it.
- **Mod-to-Game interfaces**: Implemented by your mod, called by the game to request features, data, or content.

---

## Key Components

### Game-to-Mod Interfaces (provided by the game)
These are the hooks your mod can use to work with the game:
- **`IAiApiProvider`** - Gives access to active AI text/voice systems.
- **`ISettingsProvider`** - Save and load persistent mod settings.
- **`IChatProvider`** - Get current chat data for AI text processing.
- **`ISkinDatabaseProvider`** - Add, remove, or replace skins in the game.

### Mod-to-Game Interfaces (implemented by your mod)
These tell the game what your mod can do:
- **`ITextAiAccessor`** - Provide text generation.
- **`IVoiceAiAccessor`** - Provide voice generation.
- **`ISkinAccessor`** - Register skins with the game.
- **`ISettingsAccessor`** - Integrate with game settings.
- **`ICreatedOnLoad`** - Provide a prefab to spawn when the game starts.
- **`IModPanelCreator`** - Add buttons or panels to the mod settings UI.
- **`Skin locator interfaces`** - Help map skin parts to in-game targets.

### Shared Data Models
These classes are used to pass information between your mod and the game:
- **TextGen Models**: `Chat`, `Message`, `TextResult`
- **VoiceGen Models**: `VoiceResult`
- **Skin Models**: `SkinInfo`, `PropInfo`, `FacialExpressionData`, etc.

---

## How It Works

1. The game loads your mod and looks for classes that implement the mod interfaces defined in this API. 
2. Game-provided objects are injected into your mod through methods like `SetProvider(...)` or `GetDatabase(...)`.
3. Your mod calls back into the game using these injected providers - for example, to save settings or register skins.
4. When the game needs something from your mod (e.g., AI-generated text), it calls your implementation’s methods (e.g., `GenerateMessage(...)`).
5. Results are passed back to the game using callback actions provided in the API method signatures.
6. Your mod can also add custom UI or persistent objects via `IModPanelCreator` and `ICreatedOnLoad`.

---