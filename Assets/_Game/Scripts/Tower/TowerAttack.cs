using TMPro;
using UnityEngine;

public class TowerAttack : MonoBehaviour
{
    public LayerMask layerMask;
    public int attackDamage = 30;
    public float attackRange = 8f;
    public float attackInterval = 3f;

    [SerializeField] float timer = 0f;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= attackInterval)
        {
            TowerAttackDamage();
            timer = 0f;
        }
    }

    public void TowerAttackDamage()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, attackRange, layerMask);
        foreach (var collider in colliders)
        {
            var enemy = collider.GetComponent<EnemyHealt>();
            if (enemy == null) continue;

            enemy.TakeDamage(attackDamage);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}
