using UnityEngine;
using Zenject;

namespace ITAcademy
{
    public class SecondTestInstaller : MonoInstaller
    {
        [SerializeField] private GameObject _playerPrefab;
        [SerializeField] private GameObject _enemyPrefab;

        public override void InstallBindings()
        {
            Container.BindInterfacesTo<GameplayController>().AsSingle().NonLazy();
            Container.Bind<IPlayer>().FromComponentInNewPrefab(_playerPrefab).AsSingle();
            Container.BindFactory<Enemy, EnemyFactory>().FromComponentInNewPrefab(_enemyPrefab);
        }
    }
}