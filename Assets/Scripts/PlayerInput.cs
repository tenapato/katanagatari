﻿
using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;
 
public class PlayerInput : MonoBehaviour
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

    public Controls control;
    private Vector2 movementInput;

    /* Estar son variables de pruebas para el co-op */
    [SerializeField]
    int PlayerID;


    //ControlsManager controlsManager;
    
    


    /*----------------------------*/
   

    private void Awake() {
        control = new Controls();
        //control.Player.SetCallbacks(this);
        this.control.Player.Jump.performed += ctx => Jump();
        this.control.Player.Circle.performed += ctx => CircleAttack();
        this.control.Player.Triangle.performed += ctx => TriangleAttack();
        this.control.Player.Square.performed += ctx => SquareAttack();
        
    }

    private void OnEnable() {
        control.Enable();
    }

    private void OnDisable() {
        control.Disable();
    }
    

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
        //controlsManager = FindObjectOfType<ControlsManager>();
        
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
    public void OnMove(InputAction.CallbackContext ctx) => movementInput = ctx.ReadValue<Vector2>(); // Esta funcion mueve al personaje
    
        
    void Update()
    {

        if(canMove){

            transform.Translate(new Vector3(movementInput.x,0,movementInput.y)* speed * Time.deltaTime);
            
            


            animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        } 


        //rb.velocity = motion;

        /*
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

    */

    } //end of void update


      void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.tag == "Ground"){
            grounded = true;
            animator.SetBool("isJumping", false);
            animator.SetBool("jumpAttack", false);
            speed = 7;
            
        }
    }


    void CircleAttack(){
        if(Time.time>nextAttack[0] && grounded && !isShielding && canAttack){
            this.canAttack = false;
            this.isAttacking();
            this.animator.SetTrigger("Light");
            nextAttack[0] = Time.time+delay[0];
        
        }
    }

    void TriangleAttack(){
        if(Time.time>nextAttack[1] && grounded && !isShielding && canAttack){
            canAttack = false;
            animator.SetTrigger("test");
            nextAttack[1] = Time.time+delay[1];
            isAttacking(); //el segundo ataque no sale, arreglar
        }
    }

    void SquareAttack(){
        if(Time.time>nextAttack[2] && grounded && !isShielding && canAttack){
            canAttack = false;
            isAttacking();
            animator.SetTrigger("Strong");
            nextAttack[2] = Time.time+delay[2];
        }
    }

    void Jump(){

    }


}
