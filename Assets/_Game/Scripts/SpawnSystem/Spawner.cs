using UnityEngine;
using Game.Enemy;
using Game.Combat;

namespace Game.Spawning
{
    public sealed class Spawner : MonoBehaviour
    {
        [SerializeField] private SpawnPointGroup spawnPointGroup;
        [SerializeField] private GameObject enemyPrefab;
        [SerializeField] private BaseTarget baseTarget;

        public void Spawn()
        {
            SpawnPoint spawnPoint = spawnPointGroup.GetRandom();
            if (spawnPoint == null) return;

            GameObject enemyInstance = Instantiate(
                enemyPrefab,
                spawnPoint.Position,
                spawnPoint.Rotation
            );

            EnemyController enemyController =
                enemyInstance.GetComponent<EnemyController>();

            enemyController.Initialize(baseTarget);
        }

#if UNITY_EDITOR
        [ContextMenu("Spawn Test")]
        private void SpawnTest()
        {
            Spawn();
        }
#endif
    }
}
