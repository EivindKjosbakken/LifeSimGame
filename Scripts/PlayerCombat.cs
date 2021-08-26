using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{


    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    public int attackDamage = 40;

    
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            Attack();
        }
    }

    void Attack()
    {
        // Play attack animation
        // detect enemies in range of attack
        // deal dmg to those enemies
        animator.SetTrigger("Attack");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers); 

        foreach(Collider2D enemy in hitEnemies)
        {
            Debug.Log("Hit" + enemy.name);
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
        }
    }


     void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return; 
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
