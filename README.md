[English](README.md) | [Русский](README_RU.md)

# Curtain for Unity

![image](https://github.com/RimuruDev/Unity-Curtain/assets/85500556/d72dde3a-34f5-4dd6-be83-a23961b0eeff)

## Overview

The Curtain system in Unity is a robust and versatile tool designed to manage transitions and loading screens across
your games or applications. It serves as a 'curtain', hiding the scene changes or loading processes that happen in the
background, providing a seamless experience for the player.

## Why Use Curtain?

Using Curtain in your Unity projects can greatly simplify the management of scene transitions and loading sequences. It
handles the display of a full-screen overlay, which can be customized and animated, to mask the loading operations that
may distract the user or disrupt the gameplay experience.

## Features

- **Animated Transitions**: Curtain can smoothly transition in and out with customizable animations.
- **Callback Support**: Execute any post-animation logic using callbacks, perfect for loading scenes or resources in the
  background.
- **Customizable Appearance**: Easily modify the look and feel of your curtain through Unity's ScriptableObject to match
  your game's aesthetic.
- **Delay Control**: Specify delays for hiding the curtain, allowing for flexible timing with your game's loading
  processes.


## Installation << (Obsolete!)

1. Clone the repository or download the latest release.
2. Import the Curtain package into your Unity project.
3. Drag and drop the `CurtainView` prefab onto your canvas in the desired scene.

## Usage

First, ensure that your scene contains an instance of `CurtainView`, and that the `CurtainService` is properly
initialized and injected where you need to control the curtain.

### Showing the Curtain

Invoke `curtainService.ShowCurtain()` to cover the screen. This is typically done just before you start a loading
operation.

```csharp
curtainService.ShowCurtain(isAnimated: true, callback: () =>
{
    // This block of code will execute after the curtain has fully appeared.
    // You can start loading your scene or resources here.
});
```

## Hiding the Curtain

Once your loading operation is complete, call curtainService.HideCurtain() to remove the curtain and reveal the updated
content.

```csharp
curtainService.HideCurtain(isAnimated: true, callback: () =>
{
    // This code will execute after the curtain has fully disappeared.
    // This is the perfect place to transition to a new scene or perform other post-loading operations.
});
```

## Delayed Hiding

If you need to keep the curtain displayed for a set amount of time (for example, to show a loading animation or a
branding screen), you can use the delayed hide function.

```csharp
// Assuming you have a curtainConfig object with a HideDelay property
curtainService.HideCurtain(curtainConfig.HideDelay, () =>
{
    // Code to execute after the delay and the curtain has been hidden.
});
```

## Dependencies:

- NaughtyAttributes: [Asset Store](https://assetstore.unity.com/packages/tools/utilities/naughtyattributes-129996), [GitHub](https://assetstore.unity.com/packages/tools/utilities/naughtyattributes-129996)
- DoTween: [Asset Store](https://assetstore.unity.com/packages/tools/animation/dotween-hotween-v2-27676)
- Zenject: [Asset Store](https://assetstore.unity.com/packages/tools/utilities/extenject-dependency-injection-ioc-157735), [GitHub](https://github.com/modesttree/Zenject)

## Contributing

Your contributions are welcome! If you have any suggestions for improving this utility, please feel free to fork the
repository, make your changes, and submit a pull request.

## License

This project is licensed under the MIT License - see the LICENSE file for details.

### Developed by RimuruDev
