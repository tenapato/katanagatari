using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectiorManager : MonoBehaviour
{   
    public bool characterIsSelected = false;

    public int CharId;
    GameObject go;
   // GameObject ch1;
   // GameObject ch2;
    
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Cursor") && CharId == 1){
            
            go.GetComponent<CursorMovement>().characterIsSelected = true;
            Debug.Log("first char ");

        }

        if(col.gameObject.CompareTag("Cursor") && CharId == 2){
            
            go.GetComponent<CursorMovement>().characterIsSelected = true;
            Debug.Log("second char ");

        }
        
    }


    private void Start() {
         go = GameObject.Find("CursorP1");
        // ch1 = GameObject.Find("Ch1");
        // ch2 = GameObject.Find("Ch2");
    }
}
