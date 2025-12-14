using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth instance;
    [SerializeField] PlayerBarrier playerShield;

    [Header("Player")]
    public int maxHealt = 100;
    [SerializeField] public int currentHealth;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        playerShield = GetComponent<PlayerBarrier>();

        currentHealth = maxHealt;
        HealthClamp();
    }

    public void TakeDamage(int damage)
    {
        if (playerShield != null && playerShield.IsActive())
        {
            damage = playerShield.AbsorbDamage(damage);
        }

        if (damage <= 0) return;

        currentHealth -= damage;
        HealthClamp();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void SetHeal(int amount)
    {
        currentHealth += amount;
        HealthClamp();
    }

    void HealthClamp()
    {
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealt);
    }    

    public void Die()
    {
        Debug.Log("Player öldü \nRestart ekraný yap");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            TakeDamage(10);
        }
    }
}
