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

namespace RimuruDev.Internal.Codebase.Runtime.Common
{
    [DisallowMultipleComponent]
    public sealed class ImmortalGameObject : MonoBehaviour
    {
        [SerializeField] private bool setParentNull = true;

        private void Awake()
        {
            ApplyDontDestroyOnLoad();
        }

        private void ApplyDontDestroyOnLoad()
        {
            if (setParentNull)
                transform.SetParent(null);

            DontDestroyOnLoad(gameObject);
        }
    }
}