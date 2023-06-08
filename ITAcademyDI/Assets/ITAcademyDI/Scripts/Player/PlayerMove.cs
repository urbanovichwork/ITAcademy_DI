using UnityEngine;
using UnityEngine.AI;

namespace ITAcademy
{
    public class PlayerMove : MonoBehaviour, IPlayer
    {
        [SerializeField] private NavMeshAgent _agent;

        public void MoveTo(Vector3 pos)
        {
            _agent.SetDestination(pos);
        }

        public Vector3 GetCurrentPosition() => transform.position;
    }
}