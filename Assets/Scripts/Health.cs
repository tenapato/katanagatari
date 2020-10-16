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

    //public Slider powerBar;




    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
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

            //Agregar que mientras te esten pegando no te puedas mover
        }
        if(currentHealth <= 0){
            Debug.Log("Oponent Died");
            animator.SetTrigger("Died");
            animator.SetBool("Death", true);
        }
    }



   




}
