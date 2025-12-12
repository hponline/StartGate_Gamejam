using UnityEngine;
using UnityEngine.AI;

namespace Game.Enemy
{
    [RequireComponent(typeof(NavMeshAgent))]
    public sealed class EnemyMovement : MonoBehaviour
    {
        private NavMeshAgent agent;

        private void Awake()
        {
            agent = GetComponent<NavMeshAgent>();
        }

        public void MoveTo(Vector3 targetPosition)
        {
            agent.SetDestination(targetPosition);
        }
    }
}
