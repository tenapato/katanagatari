using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public int maxHealth;
    public int currentHealth;
    public Slider healthBar;
    bool display = false;
    Animator animator;
    public AudioSource getHit;

    //public Slider powerBar;
    public AudioClip hit;
    Vector3 knockback;
    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        if(healthBar != null){
            healthBar.maxValue = maxHealth;
            healthBar.value = currentHealth;
            display = true;
        }
    }

    public void TakeDamage(int amount){
        currentHealth -= amount;
        if(display){
            healthBar.value = currentHealth;
            animator.SetTrigger("TakeHit");
            gameObject.GetComponent<PlayerInput>().canAttack = false;
            gameObject.GetComponent<PlayerInput>().isAttacking();
            //Esta parte controla el knockback dependiendo del daño que reciba
            if(amount == 20){ //Heavy Hit Knockback
                knockback.x = 500;
                rb.AddForce(knockback);
            }else if(amount == 10){ // Long Hit Knockback
                knockback.x = 200;
                rb.AddForce(knockback);
            }
            
            
            getHit.PlayOneShot(hit);//arreglar que suene cuando te golpean

            //Agregar que mientras te esten pegando no te puedas mover
        }
        if(currentHealth <= 0){
            Debug.Log("Oponent Died");
            animator.SetTrigger("Died");
            animator.SetBool("Death", true);
        }
    }



   




}
