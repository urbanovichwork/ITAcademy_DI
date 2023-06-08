using System;
using JetBrains.Annotations;
using UnityEngine;
using Zenject;

namespace ITAcademy
{
    [UsedImplicitly]
    public class GameplayController : IInitializable, ITickable, IDisposable
    {
        private readonly IPlayer _player;
        private readonly EnemyFactory _enemyFactory;
        private readonly GameplayInfo _gameplayInfo;
        private readonly InputHandler _inputHandler;

        public GameplayController(IPlayer player, EnemyFactory enemyFactory, GameplayInfo gameplayInfo,
            InputHandler inputHandler)
        {
            _gameplayInfo = gameplayInfo;
            _enemyFactory = enemyFactory;
            _player = player;
            _inputHandler = inputHandler;
        }

        public void Initialize()
        {
            _inputHandler.OnClicked += OnClicked;
        }

        private void OnClicked(Vector3 pos)
        {
            _player.MoveTo(pos);
        }

        public void Tick()
        {
        }

        public void Dispose()
        {
            _inputHandler.OnClicked -= OnClicked;
        }
    }
}