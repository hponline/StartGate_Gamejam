using UnityEngine;
using Game.Combat;

namespace Game.Enemy
{
    public sealed class EnemyController : MonoBehaviour
    {
        private EnemyMovement movement;

        private void Awake()
        {
            movement = GetComponent<EnemyMovement>();
        }

        public void Initialize(BaseTarget baseTarget)
        {
            movement.MoveTo(baseTarget.Position);
        }
    }
}
