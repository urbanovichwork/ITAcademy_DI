using System;
using DG.Tweening;
using UnityEngine;

namespace ITAcademy
{
    public class SimpleTween : MonoBehaviour
    {
        private void Start()
        {
            transform.DOMove(transform.position + Vector3.right * 2, 5f).SetLoops(100, LoopType.Yoyo);
        }

        private void OnDestroy()
        {
            DOTween.Kill(transform);
        }
    }
}