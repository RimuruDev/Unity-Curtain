// **************************************************************** //
//
//   Copyright (c) RimuruDev. All rights reserved.
//   Contact me: 
//          - Gmail:    rimuru.dev@gmail.com
//          - GitHub:   https://github.com/RimuruDev
//          - LinkedIn: https://www.linkedin.com/in/rimuru/
//          - GitHub Organizations: https://github.com/Rimuru-Dev
//
// **************************************************************** //

using Zenject;
using UnityEngine;
using RimuruDev.Internal.Codebase.Infrastructure.Services.Curtain;
using RimuruDev.Internal.Codebase.Infrastructure.Services.StaticData;

namespace RimuruDev.Internal.Codebase.Runtime.Example
{
    public sealed class Bootstrupper : MonoBehaviour
    {
        private ICurtainService curtainService;
        private IStaticDataService staticData;

        [Inject]
        private void Constructor(ICurtainService curtainService, IStaticDataService staticData)
        {
            this.staticData = staticData;
            this.curtainService = curtainService;
        }

        private void Awake()
        {
            // Simulate BootState
            staticData.Init();
            curtainService.Init();
        }

        private void Start()
        {
            curtainService.ShowCurtain();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.S))
                ShowCurtain();

            if (Input.GetKeyDown(KeyCode.H))
                HideCurtain();
        }

        private void ShowCurtain()
        {
            curtainService.ShowCurtain(true, () => { Debug.Log("<color=yellow>Show Curtain</color>"); });
        }

        private void HideCurtain()
        {
            var curtainConfig = staticData.ForCurtain();
            curtainService.HideCurtain(curtainConfig.HideDelay, () => { Debug.Log("<color=yellow>Hide Curtain</color>"); });
        }
    }
}