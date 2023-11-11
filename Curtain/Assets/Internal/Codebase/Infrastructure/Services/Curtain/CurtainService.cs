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
    /// <summary>
    /// Provides functionality to show and hide a curtain for loading screens.
    /// </summary>
    public sealed class CurtainService : ICurtainService
    {
        private readonly IUIFactory uiFactory;
        private CurtainView curtainView;

        /// <summary>
        /// Constructor that resolves dependencies.
        /// </summary>
        /// <param name="uiFactory">Factory to create UI elements.</param>
        [Inject]
        public CurtainService(IUIFactory uiFactory) =>
            this.uiFactory = uiFactory;

        /// <summary>
        /// Initializes the curtain service by creating the curtain view.
        /// </summary>
        public void Init() =>
            curtainView = uiFactory.CreateCurtain();

        /// <summary>
        /// Shows the curtain with optional animation.
        /// </summary>
        /// <param name="isAnimated">Determines if the curtain should be shown with an animation.</param>
        /// <param name="callback">Callback to be invoked after the curtain is shown.</param>
        public void ShowCurtain(bool isAnimated = true, Action callback = null) =>
            curtainView.ShowCurtain(isAnimated, callback);

        /// <summary>
        /// Hides the curtain with optional animation.
        /// </summary>
        /// <param name="isAnimated">Determines if the curtain should be hidden with an animation.</param>
        /// <param name="callback">Callback to be invoked after the curtain is hidden.</param>
        public void HideCurtain(bool isAnimated = true, Action callback = null) =>
            curtainView.HideCurtain(isAnimated, callback);

        /// <summary>
        /// Hides the curtain after a delay with optional animation.
        /// </summary>
        /// <param name="startDelay">Delay before starting the hide animation.</param>
        /// <param name="callback">Callback to be invoked after the curtain is hidden.</param>
        public void HideCurtain(float startDelay, Action callback = null) =>
            curtainView.HideCurtain(startDelay, callback);
    }
}