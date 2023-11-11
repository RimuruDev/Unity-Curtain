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

namespace RimuruDev.Internal.Codebase.Infrastructure.Services.Resource
{
    public interface IResourceLoaderService
    {
        public TResource Load<TResource>(string path) where TResource : Object;
        public TResource[] LoadAll<TResource>(string path) where TResource : Object;
    }
}