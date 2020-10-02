
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

    Vector3 motion;
    Rigidbody2D rb;
    SpriteRenderer sr;

    private bool jumpAttack;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponentInChildren<SpriteRenderer>();
        grounded = true;
        canMove = true;
        
    }

    IEnumerator WaitForSeconds(){ //esta corrutina vuelve a poner el booleano que activa el movimiento en true
        yield return new WaitForSeconds(1);
        canMove = true;
    }

    void wait(){
        StartCoroutine(WaitForSeconds());
        
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
        if ((Input.GetKeyDown(KeyCode.Y) && Time.time>nextAttack[1] && grounded)){  //mid attack
            //RigidbodyConstraints2D.FreezePositionX;
            //rb.constraints = RigidbodyConstraints2D.FreezePositionX;
            canMove = false; //arreglar
            animator.SetTrigger("test");
            nextAttack[1] = Time.time+delay[1];
            
        } else if(Input.GetKeyUp(KeyCode.Y)){
            wait();
        }

        
        if ((Input.GetKeyDown(KeyCode.E)) && Time.time>nextAttack[2]){  //strong attack
            animator.SetTrigger("Strong");
            nextAttack[2] = Time.time+delay[2];
            
        }
        
        if ((Input.GetKeyDown(KeyCode.R)) && Time.time>nextAttack[0]){ //light attack
            animator.SetTrigger("Light");
            nextAttack[0] = Time.time+delay[0];
        }
         if ((Input.GetKeyDown(KeyCode.T))){
            animator.SetTrigger("Super");
         }
        if (Input.GetKeyDown(KeyCode.H) && grounded){
            animator.SetBool("Shield", true);

        }

        else if(Input.GetKeyUp(KeyCode.H)){
            animator.SetBool("Shield", false);
        }

        if(Input.GetKeyDown(KeyCode.Space) && grounded){
            rb.AddForce(jumpForce);
            grounded = false;
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
            
        }
    }


}


//GetKeyDown y GetKey Up