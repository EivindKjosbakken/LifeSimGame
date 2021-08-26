using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int maxHealth = 100;
    private int currentHealth;

    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        // play animation

        animator.SetTrigger("Hurt");

        if (currentHealth <= 0)
        {
            Die();
        }
    }


    void Die()
    {
        // die animation
        //disable enemy
        Debug.Log("Enemy died");
        animator.SetBool("IsDead", true);
        GetComponent<Collider2D>().enabled = false;
        GetComponent<CircleCollider2D>().enabled = false;

        this.enabled = false;

    }
   
}
