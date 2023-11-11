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
using RimuruDev.Internal.Codebase.Runtime.CurtainLogic;
using RimuruDev.Internal.Codebase.Infrastructure.AssetManagement;
using RimuruDev.Internal.Codebase.Infrastructure.Services.StaticData;

namespace RimuruDev.Internal.Codebase.Infrastructure.Factorys
{
    public sealed class UIFactory : IUIFactory
    {
        private readonly IAssetProvider assetProvider;
        private readonly IStaticDataService staticData;

        [Inject]
        public UIFactory(IAssetProvider assetProvider, IStaticDataService staticData)
        {
            this.assetProvider = assetProvider;
            this.staticData = staticData;
        }

        public CurtainView CreateCurtain()
        {
            var config = staticData.ForCurtain();
            var view = assetProvider.Instantiate(config.CurtainView);

            view.Constructor(config.AnimationDuration);

            return view;
        }
    }
}