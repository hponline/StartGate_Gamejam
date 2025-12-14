using UnityEngine;

public class OrbSpawner : MonoBehaviour
{
    public static OrbSpawner instance;

    public GameObject[] orbPrefabs;

    void Awake()
    {
        instance = this;
    }

    public void SpawnRandomOrb(Vector3 position)
    {
        int index = Random.Range(0, orbPrefabs.Length);
        Instantiate(orbPrefabs[index], position, Quaternion.identity);
    }
}
