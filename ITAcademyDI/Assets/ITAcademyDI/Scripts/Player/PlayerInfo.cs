using System;
using UnityEngine;

namespace ITAcademy
{
    [Serializable]
    public struct PlayerInfo
    {
        [field: SerializeField] public int TotalCollision { get; set; } 
    }
}