
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

    
    //public Animator animator;
    Animator animator;

    public bool isShielding;

    public Controls control;
    private Vector2 movementInput;

    /* Estar son variables de pruebas para el co-op */
    [SerializeField]
    public int PlayerID;

    float move_x;
    //ControlsManager controlsManager;
    
    public bool canActivateSuper;
    //public bool superActivated;

    public AudioSource audio;
    /*----------------------------*/

    public bool dead;
   
    public Transform Oponent;
    public Transform Player;

    public bool FacingRight;

    public int test;

    public int canPlay;

    private void Awake() {
        control = new Controls();
        //control.Player.SetCallbacks(this);
        //var actionMap = new InputActionMap();

        control.devices = new[] {Gamepad.all[PlayerID]};

            this.control.Player.Jump.performed += ctx => Jump();
            this.control.Player.Circle.performed += ctx => CircleAttack();
            this.control.Player.Triangle.performed += ctx => TriangleAttack();
            this.control.Player.Square.performed += ctx => SquareAttack();
            this.control.Player.Circle.performed += ctx => JumpAttack();
            this.control.Player.L2.performed += ctx => SuperAttack();
            this.control.Player.R1.performed += ctx => Shield();
            this.control.Player.R1.canceled += ctx => ShieldDrop();
            this.control.Player.R2.performed += ctx => Dodge();
            this.control.Player.Move.performed += ctx => move_x = ctx.ReadValue<float>();
            this.control.Player.Move.canceled += ctx => move_x = 0;

        
        
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
        canPlay = 0;
       test = PlayerPrefs.GetInt("Player1Char");
        Debug.Log("Player1 char:" + test);
        animator = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponentInChildren<SpriteRenderer>();
        grounded = true;
        canMove = true;
        canAttack = true;
        isShielding = false;
        canJump = true;
        //controlsManager = FindObjectOfType<ControlsManager>();
        canActivateSuper = false;
        //superActivated = false;
        dead = false;

        //Esto sirve para inicializar el knockback
        float distance = Oponent.position.x - Player.position.x;
        if(distance > 0){
            FacingRight = true;
           gameObject.GetComponent<Health>().facingLeft = false;
        }
        if(distance < 0){
             gameObject.GetComponent<Health>().facingLeft = true;
        }
        //**************************************************************/
    }


    public void isAttacking(){ //este meteodo detiene el movimiento mientras esta attackando
        motion.x = 0;
        canMove = false;
        canJump = false;
        motion.y = rb.velocity.y;
        rb.velocity = motion;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
    }

  
    // Update is called once per frame
    //public void OnMove(InputAction.CallbackContext ctx) => movementInput = ctx.ReadValue<Vector2>(); // Esta funcion mueve al personaje
    
        
    void Update()
    {

        canPlay = PlayerPrefs.GetInt("canPlay");
        if(canPlay == 1){
            if(!dead){
        //if(canMove && PlayerID == 1){ // este player id es para que solo se mueva 1 personaje
            if(canMove && !isShielding){
               float distance = Oponent.position.x - Player.position.x;  //esto calcula la distancia entre tu y tu oponente para que siempre se esten volteando a ver
                if(distance > 0 && !FacingRight){
                    //transform.Rotate(0, 180, 0);
                    //transform.localScale = new Vector3(0.5f,0.5f,0.5f);
                    transform.RotateAround(Player.position, Vector3.up, 180);
                    FacingRight = !FacingRight;
                    gameObject.GetComponent<Health>().facingLeft = false;
                }
                if(distance < 0 && FacingRight){
                    //transform.Rotate(0, 180, 0);
                    //transform.localScale = new Vector3(-0.5f,0.5f,0.5f);
                    transform.RotateAround(Player.position, Vector3.up, 180);
                    FacingRight = !FacingRight;
                    gameObject.GetComponent<Health>().facingLeft = true;
                }
                
                if(FacingRight && PlayerID == 0){
                    transform.Translate(new Vector3(move_x,0,0)* speed * Time.deltaTime);
                }
                if(!FacingRight && PlayerID == 0){
                    transform.Translate(new Vector3(-move_x,0,0)* speed * Time.deltaTime);
                }
                if(FacingRight && PlayerID == 1){
                    transform.Translate(new Vector3(-move_x,0,0)* speed * Time.deltaTime);
                }
                if(!FacingRight && PlayerID == 1){
                    transform.Translate(new Vector3(move_x,0,0)* speed * Time.deltaTime);
                }
                
                 //transform.Translate(new Vector3(move_x,0,0)* speed * Time.deltaTime);
                
            }
            


            animator.SetFloat("Speed", Mathf.Abs(move_x));
    
            animator.SetFloat("goingUp", rb.velocity.y);

            }
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


    void CircleAttack(){
        Debug.Log(PlayerID);
        if(Time.time>nextAttack[0] && grounded && !isShielding && canAttack && !dead && canPlay == 1){
            this.canAttack = false;
            this.isAttacking();
            this.animator.SetTrigger("Light");
            nextAttack[0] = Time.time+delay[0];
            audio.Play();
        
        }
    }

    void TriangleAttack(){
        if(Time.time>nextAttack[1] && grounded && !isShielding && canAttack && !dead && canPlay == 1){
            canAttack = false;
            animator.SetTrigger("test");
            nextAttack[1] = Time.time+delay[1];
            isAttacking(); //el segundo ataque no sale, arreglar
            audio.Play();
        }
    }

    void SquareAttack(){
        if(Time.time>nextAttack[2] && grounded && !isShielding && canAttack && !dead && canPlay == 1){
            canAttack = false;
            isAttacking();
            animator.SetTrigger("Strong");
            nextAttack[2] = Time.time+delay[2];
            audio.Play();
        }
    }

    void Jump(){

            if(grounded && !isShielding && canJump && !dead && canPlay == 1){
            rb.AddForce(jumpForce);
            grounded = false;
            speed = 4;
            //animator.SetBool("isJumping", true);
            animator.SetTrigger("jump");
            }
            
    }
    
    void JumpAttack(){
        if(!grounded && !dead){
        animator.SetBool("jumpAttack", true);
        audio.Play();
        }
    }
    

    void Shield(){ //se activa con R1
        if(grounded && canAttack && !dead && canPlay == 1){
        //sAttacking();
        
        canMove = false;
        canJump = false;
        animator.SetBool("Shield", true);
        isShielding = true;
        }
    }
    void ShieldDrop(){
        animator.SetBool("Shield", false);
        canMove = true;
        canJump = true;
        isShielding = false;
    }
    
    void Dodge(){
        if(grounded && Time.time>nextAttack[0] && !dead && canPlay == 1){
        animator.SetTrigger("Dodge");
        nextAttack[0] = Time.time+delay[0];
        isAttacking();
        }
    }

    
    void SuperAttack(){ //L2
        if(Time.time>nextAttack[0] && grounded && !isShielding && canActivateSuper && !dead){
        canActivateSuper = false;
        isAttacking();
        animator.SetTrigger("Super");
        nextAttack[0] = Time.time+delay[0];

        if(!canActivateSuper){
            gameObject.GetComponent<PowerBar>().superActivated = true;
        }

        }
    }


}

