# Unity-Curtain

![image](https://github.com/RimuruDev/Unity-Curtain/assets/85500556/d72dde3a-34f5-4dd6-be83-a23961b0eeff)

## How to use
- ..
- ..
- ..

## Usefulness
- ..
- ..
- ..

## Docs
- ..
- ..
- ..

## Customize
- ..
- ..
- ..

## Dependencies:
- NaughtyAttributes: [Asset Store](https://assetstore.unity.com/packages/tools/utilities/naughtyattributes-129996), [GitHub](https://assetstore.unity.com/packages/tools/utilities/naughtyattributes-129996)
- DoTween: [Asset Store](https://assetstore.unity.com/packages/tools/animation/dotween-hotween-v2-27676)
- Zenject: [Asset Store](https://assetstore.unity.com/packages/tools/utilities/extenject-dependency-injection-ioc-157735), [GitHub](https://github.com/modesttree/Zenject)

# ..
![image](https://github.com/RimuruDev/Unity-Curtain/assets/85500556/8b7e6feb-5f5c-4174-a4ca-f1e0d6a9955e)

# Curtain for Unity

## Overview
Curtain is a utility system designed to manage loading screens in Unity applications. It provides an easy way to display a full-screen curtain that obscures the view while the level or scene is being loaded or constructed in the background.

## Features
- Smoothly show and hide the loading curtain with optional animation.
- Highly customizable through Unity's ScriptableObject architecture.
- Supports delayed curtain hiding to synchronize with your loading processes.

## Installation
To integrate the Curtain system into your Unity project, follow these steps:
1. Clone the repository or download the latest release.
2. Import the Curtain package into your Unity project.
3. Add the `CurtainView` prefab to your canvas.

## Usage
1. Initialize the `StaticDataService` and `CurtainService` in your bootstrapper or BootState class.
2. Call `curtainService.ShowCurtain()` to display the curtain.
3. Once loading is complete, use `curtainService.HideCurtain()` to hide the curtain.

## Example
```csharp
public sealed class Bootstrapper : MonoBehaviour
{
    private ICurtainService curtainService;
    private IStaticDataService staticData;

    [Inject]
    private void Constructor(ICurtainService curtainService, IStaticDataService staticData)
    {
        this.curtainService = curtainService;
        this.staticData = staticData;
    }

    private void Awake()
    {
        // Initialize services
        staticData.Init();
        curtainService.Init();
    }

    private void Start()
    {
        // Show the curtain
        curtainService.ShowCurtain();
    }

    private void Update()
    {
        // Toggle curtain with keyboard input for demonstration
        if (Input.GetKeyDown(KeyCode.S))
            curtainService.ShowCurtain();

        if (Input.GetKeyDown(KeyCode.H))
            HideCurtain();
    }

    private void HideCurtain()
    {
        var curtainConfig = staticData.ForCurtain();
        curtainService.HideCurtain(curtainConfig.HideDelay, () => Debug.Log("Curtain hidden"));
    }
}
```