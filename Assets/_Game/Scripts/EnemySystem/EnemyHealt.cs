using UnityEngine;

public class EnemyHealt : MonoBehaviour
{
    [SerializeField] EnemyHealthBar healthBar;
    public GameObject canvasHealth;
    public int health = 100;
    [SerializeField] public float currentHealth;


    private void Awake()
    {
        currentHealth = health;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        healthBar.UpdateHealhtBar(health, currentHealth);

        if (currentHealth <= 0) 
        {
            TryDropOrb();
            Destroy(gameObject);
        }
    }

    void TryDropOrb()
    {
        if (Random.value <= 0.5f)
        {
            OrbSpawner.instance.SpawnRandomOrb(transform.position);
        }
    }
}
