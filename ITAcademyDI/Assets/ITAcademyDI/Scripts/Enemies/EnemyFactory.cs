using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace ITAcademy
{
    public class EnemyFactory
    {
        private readonly DiContainer _container;
        private readonly List<EnemyInfo> _enemyInfos;

        public EnemyFactory(DiContainer container, List<EnemyInfo> enemyInfos)
        {
            _container = container;
            _enemyInfos = enemyInfos;
        }

        public void Create()
        {
            var enemyInfo = _enemyInfos[Random.Range(0, _enemyInfos.Count)];
            var enemy = Object.Instantiate(enemyInfo.Prefab).GetComponent<Enemy>();
            enemy.transform.position = Random.insideUnitCircle * 10;
            enemy.Init();
            _container.Inject(enemy);
        }
    }
}