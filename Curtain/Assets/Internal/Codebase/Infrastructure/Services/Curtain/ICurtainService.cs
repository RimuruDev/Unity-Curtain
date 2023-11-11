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

namespace RimuruDev.Internal.Codebase.Infrastructure.Services.Curtain
{
    public interface ICurtainService
    {
        public void Init();
        public void ShowCurtain(bool isAnimated = true, Action callback = null);
        public void HideCurtain(bool isAnimated = true, Action callback = null);
        public void HideCurtain(float startDelay, Action callback = null);
    }
}