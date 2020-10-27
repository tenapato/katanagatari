/* Authors
- Patricio Tena A01027293
- Rodrigo Benavente A01026973
- Fernando Garrato A01027503

    This script handles the health of the players and also manages the game when they die
*/
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
    public bool isShielding;

    public bool facingLeft;

    public bool Dodging;
    public AudioSource deathAudio;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody2D>();
        isShielding = false;
        currentHealth = maxHealth;
        if(healthBar != null){
            healthBar.maxValue = maxHealth;
            healthBar.value = currentHealth;
            display = true;
        }
    }

    public void TakeDamage(int amount){

        
       
             
         
        if(!Dodging){

        
        if(display && amount != 0 && !isShielding){
            currentHealth -= amount;
            healthBar.value = currentHealth;
            animator.SetTrigger("TakeHit");
            gameObject.GetComponent<PlayerInput>().canAttack = false;
            gameObject.GetComponent<PlayerInput>().isAttacking();
            //Esta parte controla el knockback dependiendo del daño que reciba  
            if(facingLeft){
                if(amount == 20){ //Heavy Hit Knockback
                    knockback.x = 300;
                    knockback.y = 500;
                    rb.AddForce(knockback);
                }else if(amount == 10){ // Long Hit Knockback
                    knockback.x = 200;
                    rb.AddForce(knockback);
                }else if(amount == 50){// super attack knockback
                    knockback.x = 700;
                    rb.AddForce(knockback);
                }else if(amount == 5){// short attack
                    knockback.x = 100;
                    rb.AddForce(knockback);
                }
                else if(amount == 3){// aerial attack
                    knockback.x = 100;
                    rb.AddForce(knockback);
                }
            }
            else if(!facingLeft){
                if(amount == 20){ //Heavy Hit Knockback
                    knockback.x = -500;
                    rb.AddForce(knockback);
                }else if(amount == 10){ // Long Hit Knockback
                    knockback.x = -200;
                    rb.AddForce(knockback);
                }else if(amount == 50){// super attack knockback
                    knockback.x =-700;
                    rb.AddForce(knockback);
                }else if(amount == 5){// short attack
                    knockback.x = -100;
                    rb.AddForce(knockback);
                }
                else if(amount == 3){// aerial attack
                    knockback.x = -100;
                    rb.AddForce(knockback);
                }
            }
            
            getHit.PlayOneShot(hit);//arreglar que suene cuando te golpean

            //Agregar que mientras te esten pegando no te puedas mover
        }
        }//end of doging
        if(currentHealth <= 0){
            deathAudio.Play();
            Debug.Log("Oponent Died");
            animator.SetTrigger("Died");
            animator.SetBool("Death", true);
            gameObject.GetComponent<PlayerInput>().dead = true;
            //isShielding = gameObject.GetComponent<AttackDamageV2>().isShielding;
        }
    }



   




}
