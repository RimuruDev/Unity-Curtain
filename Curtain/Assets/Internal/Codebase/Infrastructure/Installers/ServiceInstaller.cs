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
using RimuruDev.Internal.Codebase.Infrastructure.AssetManagement;
using RimuruDev.Internal.Codebase.Infrastructure.Services.Curtain;
using RimuruDev.Internal.Codebase.Infrastructure.Services.Resource;
using RimuruDev.Internal.Codebase.Infrastructure.Services.StaticData;

namespace RimuruDev.Internal.Codebase.Infrastructure.Installers
{
    public sealed class ServiceInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IAssetProvider>().To<AssetProvider>().AsSingle();
            Container.Bind<IResourceLoaderService>().To<ResourceLoaderService>().AsSingle();
            Container.Bind<IStaticDataService>().To<StaticDataService>().AsSingle();

            Container.Bind<ICurtainService>().To<CurtainService>().AsSingle();
        }
    }
}