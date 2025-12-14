using UnityEngine;

public class Orb_Shield : MonoBehaviour
{
    public PlayerBarrier playerBarrier;

    private void OnTriggerEnter(Collider other)
    {
        if (playerBarrier.IsActive())
            playerBarrier.UseShield();

        Destroy(gameObject);
    }
}
