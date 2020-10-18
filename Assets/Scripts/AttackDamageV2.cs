using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDamageV2 : MonoBehaviour
{   
    Animator animator;
    public LayerMask playerLayer;
    public Transform[] hitBox;
    public AudioSource[] audios;
    //public float attackRangeHeavy;
    //public float attackRangeLong;
    Rigidbody2D rb;
    public float [] range;
    public int [] Damage;

    Collider2D _collider;
    public bool isShielding = false;

    //public float thrust;
    //public Vector3 knockback;
    public void DamageHeavy(){
       DamageType(1);
    }  

    public void DamageLong(){
        DamageType(0);
    }

    public void DamageAir(){
        DamageType(5);
    }

    
    public void DamageShort(){
        DamageType(2);
        DamageType(3);
        DamageType(4);
    }

    public void SuperAttack(){
        DamageType(6);
    }

    public void Dodge(){
        //_collider.enabled = false;
        transform.parent.gameObject.layer = LayerMask.NameToLayer("Default");
    }
    public void unDodge(){
        transform.parent.gameObject.layer = LayerMask.NameToLayer("Player");
    }

    public void Shield(){
        transform.parent.gameObject.layer = LayerMask.NameToLayer("Default");
        //isShielding = true;
        gameObject.GetComponent<Health>().isShielding = true;
    }

    public void UnShield(){
        transform.parent.gameObject.layer = LayerMask.NameToLayer("Player");
        //isShielding = false;
        gameObject.GetComponent<Health>().isShielding = false;
    }



    void DamageType(int type){
        Collider2D col = Physics2D.OverlapCircle(hitBox[type].position, range[type], playerLayer);
        
        if(col.tag == "Player"){
            col.gameObject.GetComponent<Health>().TakeDamage(Damage[type]);
            audios[type].Play();
            
        }
            
        
    }
    /*
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player")){
                
            
                //rb.isKinematic = false;
                    
                //difference = difference.normalized * thrust;
                //rb.AddForce(difference, ForceMode2D.Impulse);
                //rb.isKinematic = true;

        }
    }*/

    void OnDrawGizmosSelected() {
        Gizmos.DrawWireSphere(hitBox[6].position, range[6]);
        //Gizmos.DrawWireSphere(hitBox[3].position, range[3]);
       // Gizmos.DrawWireSphere(hitBox[4].position, range[4]);
    }



    private void Start() {
        animator = GetComponentInChildren<Animator>();
        _collider = transform.parent.gameObject.GetComponent<Collider2D>();
       // rb = transform.parent.gameObject.GetComponent<Rigidbody2D>();
        
    }   
}
