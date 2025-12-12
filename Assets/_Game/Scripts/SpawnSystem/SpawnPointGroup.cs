using System.Collections.Generic;
using UnityEngine;

namespace Game.Spawning
{
    public sealed class SpawnPointGroup : MonoBehaviour
    {
        [SerializeField]
        private List<SpawnPoint> spawnPoints = new();

        public IReadOnlyList<SpawnPoint> SpawnPoints => spawnPoints;

        public SpawnPoint GetRandom()
        {
            if (spawnPoints.Count == 0)
            {
                Debug.LogError("SpawnPointGroup boþ!");
                return null;
            }

            int index = Random.Range(0, spawnPoints.Count);
            return spawnPoints[index];
        }
    }
}
