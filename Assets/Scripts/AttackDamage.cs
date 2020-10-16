using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDamage : MonoBehaviour
{
    public int damage;
    private void OnTriggerEnter2D(Collider2D col) {
        if(col.tag == "Player"){
            col.gameObject.GetComponent<Health>().TakeDamage(damage);
        }
    }
}

