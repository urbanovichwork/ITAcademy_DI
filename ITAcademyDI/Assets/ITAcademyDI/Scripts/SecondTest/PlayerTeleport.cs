using System.Collections;
using UnityEngine;

namespace ITAcademy
{
    public class PlayerTeleport : MonoBehaviour, IPlayer
    {
        private readonly int _circleSize = 10;
        private readonly WaitForSeconds _waitForSeconds = new(5);

        public void StartMoving()
        {
            StartCoroutine(Teleport());
        }

        public Vector3 GetCurrentPosition() => transform.position;

        private IEnumerator Teleport()
        {
            var randomPointInCircle = Random.insideUnitCircle;
            transform.position = new Vector3(randomPointInCircle.x, 0, randomPointInCircle.y) * _circleSize;
            yield return _waitForSeconds;
            StartCoroutine(Teleport());
        }
    }
}