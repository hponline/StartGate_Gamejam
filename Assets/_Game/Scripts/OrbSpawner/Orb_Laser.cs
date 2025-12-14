using UnityEngine;

public class Orb_Laser : MonoBehaviour
{
    public PlayerCombat playerCombat;

    private void OnTriggerEnter(Collider other)
    {
        playerCombat.PlayerLaserAttack();
        Destroy(gameObject);
    }
}
