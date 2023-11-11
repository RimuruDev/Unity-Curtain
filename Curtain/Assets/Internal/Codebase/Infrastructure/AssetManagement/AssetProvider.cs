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
using UnityEngine;
using Object = UnityEngine.Object;
using RimuruDev.Internal.Codebase.Infrastructure.Services.Resource;

namespace RimuruDev.Internal.Codebase.Infrastructure.AssetManagement
{
    public sealed class AssetProvider : IAssetProvider
    {
        private readonly IResourceLoaderService resourceLoader;

        [Inject]
        public AssetProvider(IResourceLoaderService resourceLoader)
        {
            this.resourceLoader = resourceLoader;
        }

        public GameObject Instantiate(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentException(path);

            var prefab = resourceLoader.Load<GameObject>(path);

            return Object.Instantiate(prefab);
        }

        public T Instantiate<T>(string path, Transform parent = null) where T : Object
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentException(path);

            var prefab = resourceLoader.Load<T>(path);

            return Object.Instantiate(prefab, parent);
        }

        public TPrefab Instantiate<TPrefab>(TPrefab prefab, Transform parent = null) where TPrefab : Object
        {
            if (prefab == null)
                throw new ArgumentNullException(nameof(prefab));

            return Object.Instantiate(prefab, parent);
        }
    }
}