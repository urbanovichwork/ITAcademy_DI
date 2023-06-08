using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace ITAcademy
{
    public class GameInstaller : MonoInstaller
    {
        [SerializeField] private Camera _camera;
        [SerializeField] private PlayerMove _playerObject;
        [SerializeField] private List<EnemyInfo> _enemyInfos;
        [SerializeField] private ParticleEmitter _particleEmitter;

        public override void InstallBindings()
        {
            Container.Bind<ILocalization>().To<UnityLocalization>().AsSingle().NonLazy();
            Container.Bind<IPreferences>().To<UnityPreferences>().AsSingle().NonLazy();

            Container.Bind<Camera>().WithId(BaseIds.GameCameraId).FromInstance(_camera);

            Container.BindInterfacesAndSelfTo<InputHandler>().AsSingle().NonLazy();
            Container.BindInterfacesAndSelfTo<GameplayInfo>().AsSingle().NonLazy();
            Container.BindInterfacesTo<GameplayController>().AsSingle().NonLazy();
            Container.BindInterfacesTo<ParticleEmitter>().FromInstance(_particleEmitter);
            Container.Bind<IPlayer>().FromInstance(_playerObject);
            Container.Bind<EnemyFactory>().AsSingle().NonLazy();
            foreach (var enemyInfo in _enemyInfos)
            {
                Container.Bind<EnemyInfo>().FromInstance(enemyInfo);
            }
        }
    }
}