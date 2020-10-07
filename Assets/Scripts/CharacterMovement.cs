
using UnityEngine;
using System.Collections;
 
public class CharacterMovement : MonoBehaviour
{   
    float horizontalMove = 0f;
    public float speed = 40f;
    public Vector3 jumpForce;

    public float [] delay;

    public float [] nextAttack;
    public bool grounded;
    public bool canMove; //bool para controlar si el jugador se puede mover o no
    public bool canAttack;

    Vector3 motion;
    Rigidbody2D rb;
    SpriteRenderer sr;

    private bool jumpAttack;

    public Animator animator;

    public bool isShielding;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponentInChildren<SpriteRenderer>();
        grounded = true;
        canMove = true;
        canAttack = true;
        isShielding = false;
        
    }


    void isAttacking(){ //este meteodo detiene el movimiento mientras esta attackando
        motion.x = 0;
        canMove = false;
        motion.y = rb.velocity.y;
        rb.velocity = motion;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
    }

  
    // Update is called once per frame
    void Update()
    {

        if(canMove){
            motion.x = Input.GetAxisRaw("Horizontal") * speed;
            horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
            motion.y = rb.velocity.y;
            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        } 


        

        rb.velocity = motion;

        //falta hacer las animaciones en metodos separados
        if ((Input.GetKeyDown(KeyCode.Y) && Time.time>nextAttack[1] && grounded && !isShielding)){  //mid attack
            //RigidbodyConstraints2D.FreezePositionX;
            //rb.constraints = RigidbodyConstraints2D.FreezePositionX;
            
            animator.SetTrigger("test");
            nextAttack[1] = Time.time+delay[1];
            isAttacking(); //el segundo ataque no sale, arreglar
        
        }

        
        if ((Input.GetKeyDown(KeyCode.E)) && Time.time>nextAttack[2] && grounded && !isShielding){  //strong attack

            isAttacking();
            animator.SetTrigger("Strong");
            nextAttack[2] = Time.time+delay[2];
            
        }
        
        if ((Input.GetKeyDown(KeyCode.R)) && Time.time>nextAttack[0] && grounded && !isShielding){ //light attack
            isAttacking();
            animator.SetTrigger("Light");
            nextAttack[0] = Time.time+delay[0];
        }
         if ((Input.GetKeyDown(KeyCode.T)) && grounded && !isShielding){ //super attack
            isAttacking();
            animator.SetTrigger("Super");
         }

        if (Input.GetKey(KeyCode.H) && grounded){ //sheild
            isAttacking();
            animator.SetBool("Shield", true);
            isShielding = true;
        }

        else if(Input.GetKeyUp(KeyCode.H)){
            animator.SetBool("Shield", false);
            isShielding = false;
        }

        if(Input.GetKeyDown(KeyCode.Space) && grounded && !isShielding){
            rb.AddForce(jumpForce);
            grounded = false;
            speed = 4;
            //animator.SetBool("isJumping", true);
            animator.SetTrigger("jump");
           
        }
    
     
         animator.SetFloat("goingUp", rb.velocity.y);

        //if(Input.GetKeyDown(KeyCode.J) && !grounded && animator.GetCurrentAnimatorStateInfo(0).IsName("jumpAttack")){
           // animator.SetBool("jumpAttack", true);
       // }
         if(Input.GetKeyDown(KeyCode.J)){
             animator.SetBool("jumpAttack", true);
         }


    } //end of void update


      void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.tag == "Ground"){
            grounded = true;
            animator.SetBool("isJumping", false);
            animator.SetBool("jumpAttack", false);
            speed = 7;
            
        }
    }


}


//GetKeyDown y GetKey Up