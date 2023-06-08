using UnityEngine;

namespace ITAcademy
{
    public interface IPlayer
    {
        void MoveTo(Vector3 pos);
        Vector3 GetCurrentPosition();
    }
}