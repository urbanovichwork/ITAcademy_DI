using System;
using System.Collections.Generic;
using UnityEngine;

namespace ITAcademy
{
    [CreateAssetMenu(menuName = "Tools/Enemy Info", fileName = "EnemyInfo")]
    public class EnemyInfo : ScriptableObject
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public GameObject Prefab { get; private set; }
        [field: SerializeField] public List<EnemyLevelInfo> EnemyLevelInfos { get; private set; }
    }

    [Serializable]
    public class EnemyLevelInfo
    {
        [field: SerializeField] public int Damage { get; private set; } = 1;
        [field: SerializeField] public int Health { get; private set; } = 100;
    }
}