
using UnityEngine;
using System.Collections;
using Enums;
 
public class CharacterMovement : MonoBehaviour
{   
    float horizontalMove = 0f;
    public float speed = 40f;
    public Vector3 jumpForce;

    public float [] delay;

    public float [] nextAttack;
    public bool grounded;
    public bool canMove; //bool para controlar si el jugador se puede mover o no
    public bool canAttack; //bool para saber cuando se esta atacando
    public bool canJump; // bool que evita que se bugge el salto

    Vector3 motion;
    Rigidbody2D rb;
    SpriteRenderer sr;

    private bool jumpAttack;

    public Animator animator;

    public bool isShielding;

    /* Estar son variables de pruebas para el co-op */
    [SerializeField]
    int PlayerID;


    ControlsManager controlsManager;
    


    /*----------------------------*/

    
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponentInChildren<SpriteRenderer>();
        grounded = true;
        canMove = true;
        canAttack = true;
        isShielding = false;
        canJump = true;
        controlsManager = FindObjectOfType<ControlsManager>();
        
    }


    void isAttacking(){ //este meteodo detiene el movimiento mientras esta attackando
        motion.x = 0;
        canMove = false;
        canJump = false;
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
        if ((Input.GetButton("PS4_TRIANGLE") && Time.time>nextAttack[1] && grounded && !isShielding && canAttack)){  //mid attack
            //RigidbodyConstraints2D.FreezePositionX;
            //rb.constraints = RigidbodyConstraints2D.FreezePositionX;
            canAttack = false;
            animator.SetTrigger("test");
            nextAttack[1] = Time.time+delay[1];
            isAttacking(); //el segundo ataque no sale, arreglar
        
        }

        
        if ((Input.GetButton("PS4_SQUARE")) && Time.time>nextAttack[2] && grounded && !isShielding && canAttack){  //strong attack
            canAttack = false;
            isAttacking();
            animator.SetTrigger("Strong");
            nextAttack[2] = Time.time+delay[2];
            
        }
        
        if ((Input.GetButton("PS4_CIRCLE")) && Time.time>nextAttack[0] && grounded && !isShielding && canAttack){ //light attack
            canAttack = false;
            isAttacking();
            animator.SetTrigger("Light");
            nextAttack[0] = Time.time+delay[0];
        }
         if ((Input.GetButton("PS4_L1")) && Time.time>nextAttack[0] && grounded && !isShielding){ //super attack
            isAttacking();
            animator.SetTrigger("Super");
            nextAttack[0] = Time.time+delay[0];
         }

        if (Input.GetButton("PS4_R2") && grounded && canAttack){ //sheild
            isAttacking();
            animator.SetBool("Shield", true);
            isShielding = true;
        }

        else if(Input.GetButtonUp("PS4_R2")){
            animator.SetBool("Shield", false);
            isShielding = false;
        }

        if(Input.GetButton("PS4_CROSS") && grounded && !isShielding && canJump){
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
         if(Input.GetButton("PS4_CIRCLE") && !grounded){
             animator.SetBool("jumpAttack", true);
         }

         if(Input.GetButton("PS4_R1") && grounded && Time.time>nextAttack[0]) { //Dodge
            animator.SetTrigger("Dodge");
            nextAttack[0] = Time.time+delay[0];
            isAttacking();
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