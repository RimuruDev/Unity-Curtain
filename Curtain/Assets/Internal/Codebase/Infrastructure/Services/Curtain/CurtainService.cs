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

using System;
using Zenject;
using RimuruDev.Internal.Codebase.Runtime.CurtainLogic;
using RimuruDev.Internal.Codebase.Infrastructure.Factorys;

namespace RimuruDev.Internal.Codebase.Infrastructure.Services.Curtain
{
    public sealed class CurtainService : ICurtainService
    {
        private readonly IUIFactory uiFactory;
        private CurtainView curtainView;

        [Inject]
        public CurtainService(IUIFactory uiFactory) =>
            this.uiFactory = uiFactory;

        public void Init() =>
            curtainView = uiFactory.CreateCurtain();

        public void ShowCurtain(bool isAnimated = true, Action callback = null) =>
            curtainView.ShowCurtain(isAnimated, callback);

        public void HideCurtain(bool isAnimated = true, Action callback = null) =>
            curtainView.HideCurtain(isAnimated, callback);

        public void HideCurtain(float startDelay, Action callback = null) =>
            curtainView.HideCurtain(startDelay, callback);
    }
}