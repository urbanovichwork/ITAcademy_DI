using UnityEngine;
using Zenject;

namespace ITAcademy
{
    public class EnemyFactory : PlaceholderFactory<Enemy>
    {
        public override Enemy Create()
        {
            var enemy = base.Create();
            enemy.transform.position = Random.insideUnitCircle * 10;
            enemy.Init();
            return enemy;
        }
    }
}