using UnityEngine;

namespace ITAcademy
{
    public interface IPlayer
    {
        void StartMoving();
        Vector3 GetCurrentPosition();
    }
}