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
using NaughtyAttributes;

namespace RimuruDev.Internal.Codebase.Runtime.CurtainLogic
{
    [CreateAssetMenu(menuName = "StaticData/Create CurtainConfig", fileName = "CurtainConfig", order = 0)]
    public sealed class CurtainConfig : ScriptableObject
    {
        [field: SerializeField] public CurtainView CurtainView { get; private set; }
        [field: SerializeField, Range(0.01f, 10f)] public float HideDelay { get; private set; } = 1.3f;
        [field: SerializeField, Range(0.01f, 10f)] public float AnimationDuration { get; private set; } = 1.5f;
        [field: SerializeField, ShowAssetPreview(256, 256)] public Sprite Icon { get; private set; }
    }
}