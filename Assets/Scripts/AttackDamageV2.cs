/* Authors
- Patricio Tena A01027293
- Rodrigo Benavente A01026973
- Fernando Garrato A01027503

    This script is used handles the damage per attack of each player.
*/

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

    int PlayerID;
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
        //transform.parent.gameObject.layer = LayerMask.NameToLayer("Default");
        transform.parent.gameObject.GetComponent<Health>().Dodging = true;
    }
    public void unDodge(){
        transform.parent.gameObject.GetComponent<Health>().Dodging = false;
       // transform.parent.gameObject.layer = LayerMask.NameToLayer("Player");
    }

    public void Shield(){

        //DamageType(7);
        //transform.parent.gameObject.layer = LayerMask.NameToLayer("Default");
        
        //isShielding = true;
        transform.parent.gameObject.GetComponent<Health>().isShielding = true;
    }

    public void UnShield(){ //falta regresar a la layer de Player1 y Player2
    /*
        Debug.Log(PlayerID);
        if(PlayerID == 0){
            transform.parent.gameObject.layer = LayerMask.NameToLayer("Player1");
        }
        if(PlayerID == 1){
            transform.parent.gameObject.layer = LayerMask.NameToLayer("Player2");
        }
        
        //isShielding = false;*/
        
        transform.parent.gameObject.GetComponent<Health>().isShielding = false;
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
        PlayerID = this.gameObject.GetComponent<PlayerInput>().PlayerID;
    }   
}
