using UnityEngine;

public class Orb_TowerRange : MonoBehaviour
{
    public TowerManager towerManager;

    private void OnTriggerEnter(Collider other)
    {
        towerManager.OnOrbCollected();
        Destroy(gameObject);
    }
}
