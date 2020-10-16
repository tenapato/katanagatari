using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeDamage : MonoBehaviour
{
    public int health = 100;
    
    
    private void OnCollisionEnter2D(Collision2D collision) {
        //Debug.Log("Pego");
            if(collision.gameObject.tag ==  "impact"){
                Debug.Log("Golpe");
                health = health - 10;
                if(health <= 0){
                    Debug.Log("Openent Died");
                }
            }
    }

}
