
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{   
    float horizontalMove = 0f;
    public float speed = 40f;
    public Vector3 jumpForce;

    Vector3 motion;
    Rigidbody2D rb;
    SpriteRenderer sr;



    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        motion.x = Input.GetAxisRaw("Horizontal") * speed;
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
        motion.y = rb.velocity.y;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));



        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(jumpForce);
        }

        rb.velocity = motion;


        if (Input.GetKeyDown(KeyCode.Space)){
            animator.SetBool("Attack", true);
        }
        else {
            animator.SetBool("Attack", false);
        }




    }
}