using UnityEngine;
using Zenject;

namespace ITAcademy
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private float _speed = 1;

        private IPlayer _player;

        private bool _followPlayer;

        [Inject]
        private void Construct(IPlayer player)
        {
            _player = player;
        }

        public void Init()
        {
            _followPlayer = true;
        }

        void Update()
        {
            if (_followPlayer)
            {
                transform.position =
                    Vector3.MoveTowards(transform.position, _player.GetCurrentPosition(), Time.deltaTime * _speed);
            }
        }
    }
}