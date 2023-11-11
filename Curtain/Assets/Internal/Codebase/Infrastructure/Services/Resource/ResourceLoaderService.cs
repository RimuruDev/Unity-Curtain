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
using System.Linq;
using UnityEngine;
using Object = UnityEngine.Object;
using RimuruDev.Internal.Codebase.Infrastructure.Exceptions;

namespace RimuruDev.Internal.Codebase.Infrastructure.Services.Resource
{
    public sealed class ResourceLoaderService : IResourceLoaderService
    {
        public TResource Load<TResource>(string path) where TResource : Object
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentException(path);

            var resource = Resources.Load<TResource>(path);

            if (resource == null)
                throw new AssetLoadException(path);

            return resource;
        }

        public TResource[] LoadAll<TResource>(string path) where TResource : Object
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentException(path);

            var resources = Resources.LoadAll<TResource>(path);

            if (resources == null)
                throw new AssetLoadException(path);

            if (resources.Any(resource => resource == null))
                throw new AssetLoadException(path);

            return resources;
        }
    }
}