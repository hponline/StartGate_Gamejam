using UnityEngine;

public class Orb_Hp : MonoBehaviour
{
    public int hp = 30;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHealth.instance.SetHeal(hp);
            Destroy(gameObject);
        }
    }
}
