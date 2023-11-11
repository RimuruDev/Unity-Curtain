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
using RimuruDev.Internal.Codebase.Infrastructure.Services.Resource;

namespace RimuruDev.Internal.Codebase.Infrastructure.Services.StaticData
{
    public sealed class StaticDataService : IStaticDataService
    {
        private readonly IResourceLoaderService resourceLoader;
        private CurtainConfig curtainConfig;

        [Inject]
        public StaticDataService(IResourceLoaderService resourceLoader)
        {
            this.resourceLoader = resourceLoader;
        }

        public void Init()
        {
            curtainConfig = resourceLoader.Load<CurtainConfig>(AssetPath.Curtain);
        }

        public CurtainConfig ForCurtain()
        {
            return curtainConfig;
        }
    }
}