using TMPro;
using UnityEngine;

public class EnemyHealt : MonoBehaviour
{
    [SerializeField] EnemyHealthBar healthBar;
    public GameObject floatingTextPrefab;

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
            Destroy(gameObject);
        }
    }
}
