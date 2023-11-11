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

using UnityEngine;

namespace RimuruDev.Internal.Codebase.Infrastructure.AssetManagement
{
    public interface IAssetProvider
    {
        public T Instantiate<T>(string path, Transform parent = null) where T : Object;
        public TPrefab Instantiate<TPrefab>(TPrefab prefab, Transform parent = null) where TPrefab : Object;
    }
}