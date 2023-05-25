using UnityEngine;
using Zenject;

namespace ITAcademy
{
    public class FirstTestInstaller : MonoInstaller
    {
        [SerializeField] private Transform _canvasTransform;
        [SerializeField] private GameObject _textChangerPrefab;

        public override void InstallBindings()
        {
            Container.Bind<string>().FromInstance("Hello World");
            Container.Bind<TextChanger>().FromComponentInNewPrefab(_textChangerPrefab).UnderTransform(_canvasTransform)
                .AsSingle().NonLazy();
            Container.BindInterfacesAndSelfTo<Greeter>().AsSingle().NonLazy();
            Container.Bind<GreeterSecond>().AsSingle().NonLazy();
        }
    }
}