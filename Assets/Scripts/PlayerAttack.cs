using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator_attack;
   
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public int attackDamage = 40;
    public LayerMask enemyLayers;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            Attack();
        }
    }
    

    void Attack(){
 
        animator_attack.SetTrigger("Attack");

        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);

        foreach (Collider enemy in hitEnemies)
        {
            // Certifique-se de que o objeto atingido tem um componente Enemy
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);

        }
    }

    void OnDrawGizmosSelected(){
        if(attackPoint == null){
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
