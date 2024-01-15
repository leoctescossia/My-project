using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHP = 100;
    public Animator animator;
    int currentHealth;
    // Start is called before the first frame update

    void Start()
    {
        currentHealth = maxHP;
    }
    public void TakeDamage(int damageAmount){
        currentHealth -= damageAmount;
        if(currentHealth <= 0){
            //Play death animation
            animator.SetTrigger("die");
            Debug.Log("die");
        }
        else{
            //Play get hit animation
            animator.SetTrigger("damage");
            Debug.Log("damage");
        }
    }
    
}
