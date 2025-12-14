using UnityEngine;

public class EnemyHealt : MonoBehaviour
{
    [SerializeField] EnemyHealthBar healthBar;
    public GameObject canvasHealth;
    public int health = 100;
    [SerializeField] public float currentHealth;

    [SerializeField] FloatingTxt floatingTextPrefab;
    [SerializeField] Vector3 textOffset = new Vector3(0, 2f, 0);

    private void Awake()
    {
        currentHealth = health;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        healthBar.UpdateHealhtBar(health, currentHealth);

        SpawnFloatingText(damage);
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

    void SpawnFloatingText(float damage)
    {
        if (floatingTextPrefab == null) return;

        FloatingTxt txt = Instantiate(
            floatingTextPrefab,
            transform.position + textOffset,
            Quaternion.identity
        );

        txt.SetText(damage);
    }

}
