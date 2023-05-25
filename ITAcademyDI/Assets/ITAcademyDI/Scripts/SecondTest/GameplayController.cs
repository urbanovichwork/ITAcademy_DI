using JetBrains.Annotations;
using Zenject;
using Input = UnityEngine.Input;

namespace ITAcademy
{
    [UsedImplicitly]
    public class GameplayController : IInitializable, ITickable
    {
        private readonly IPlayer _player;
        private readonly EnemyFactory _enemyFactory;

        public GameplayController(IPlayer player, EnemyFactory enemyFactory)
        {
            _enemyFactory = enemyFactory;
            _player = player;
        }

        public void Initialize()
        {
            _player.StartMoving();
        }

        public void Tick()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _enemyFactory.Create();
            }
        }
    }
}