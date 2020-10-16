using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDamageV2 : MonoBehaviour
{   
    Animator animator;
    public LayerMask playerLayer;
    public Transform[] hitBox;
    //public float attackRangeHeavy;
    //public float attackRangeLong;

    public float [] range;
    public int [] Damage;
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




    void DamageType(int type){
        Collider2D col = Physics2D.OverlapCircle(hitBox[type].position, range[type], playerLayer);
        if(col.tag == "Player"){
            col.gameObject.GetComponent<Health>().TakeDamage(Damage[type]);
            
        }
    }



    void OnDrawGizmosSelected() {
        Gizmos.DrawWireSphere(hitBox[6].position, range[6]);
        //Gizmos.DrawWireSphere(hitBox[3].position, range[3]);
       // Gizmos.DrawWireSphere(hitBox[4].position, range[4]);
    }



    private void Start() {
        animator = GetComponentInChildren<Animator>();
    }   
}
