using System;
using UnityEngine;
using Zenject;

namespace ITAcademy
{
    public class ParticleEmitter : MonoBehaviour, IInitializable, IDisposable
    {
        [SerializeField] private GameObject _particlePrefab;

        private InputHandler _inputHandler;

        [Inject]
        private void Construct(InputHandler inputHandler)
        {
            _inputHandler = inputHandler;
        }

        public void Initialize()
        {
            _inputHandler.OnClicked += OnClicked;
        }

        private void OnClicked(Vector3 pos)
        {
            Instantiate(_particlePrefab, pos, Quaternion.Euler(-90, 0, 0));
        }

        public void Dispose()
        {
            _inputHandler.OnClicked -= OnClicked;
        }
    }
}