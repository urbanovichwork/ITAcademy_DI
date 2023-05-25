using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace ITAcademy
{
    public class PlayerMove : MonoBehaviour, IPlayer
    {
        [SerializeField] private float _circleSize = 10;
        [SerializeField] private float _speed = 1;

        private readonly WaitForSeconds _waitForSeconds = new(5);

        private bool _isMoving;
        private Vector3 _newDestination;

        public void StartMoving()
        {
            StartCoroutine(ChangeDestination());
            _isMoving = true;
        }

        public Vector3 GetCurrentPosition() => transform.position;

        private void Update()
        {
            if (_isMoving)
            {
                transform.position = Vector3.MoveTowards(transform.position, _newDestination, Time.deltaTime * _speed);
            }
        }

        private IEnumerator ChangeDestination()
        {
            var randomPointInCircle = Random.insideUnitCircle;
            _newDestination = new Vector3(randomPointInCircle.x, 0, randomPointInCircle.y) * _circleSize;
            yield return _waitForSeconds;
            StartCoroutine(ChangeDestination());
        }
    }
}