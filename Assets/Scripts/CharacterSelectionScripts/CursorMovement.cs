  
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class CursorMovement : MonoBehaviour {

    public float speed;
    float x;
    float y;
    public CursorControls ccontrol;

    public int PlayerID;
    public int CharID;

    public bool characterIsSelected = false;

    Camera cam;

    //GameObject cursor;

    private void Start() {
        cam = Camera.main;
        
    }



	void Update () {
        
        transform.Translate(new Vector3(x,y,0)* speed * Time.deltaTime);
        
        

    }

    private void Awake() {
        ccontrol = new CursorControls();
        ccontrol.devices = new[] {Gamepad.all[PlayerID]};
        this.ccontrol.Cursor.Move.performed += ctx => x = ctx.ReadValue<float>();
        this.ccontrol.Cursor.Move.canceled += ctx => x = 0;
        this.ccontrol.Cursor.MoveUPDOWN.performed += ctx => y = ctx.ReadValue<float>();
        this.ccontrol.Cursor.MoveUPDOWN.canceled += ctx => y = ctx.ReadValue<float>();
        this.ccontrol.Cursor.Cross.performed += ctx => SelectCharacter();

       
    }
    private void OnEnable() {
        ccontrol.Enable();
    }

    private void OnDisable() {
        ccontrol.Disable();
    }

    
    public void SelectCharacter(){
        /*    
        if(characterIsSelected){
            Debug.Log("Seleccionaste a tu personaje");
        }*/
        /*
        Vector2 pointerPos = cam.ScreenToWorldPoint(cursor.transform.position);
        Collider2D col = Physics2D.OverlapPoint(pointerPos);
        
        if(col.tag == "Ch1"){
            Debug.Log("Char1");
        }*/

        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.up), 15.0f);
       // Debug.DrawRay(transform.position, Vector2.up, Color.green);
        if(hit){
        
        //Debug.Log("Hit: " + hit.collider.tag);
            
            if(hit.collider.tag == "Ch1"){
                Debug.Log("Seleccionaste al personaje 1");
                
                if(PlayerID == 0){ //Este if define el personaje y el id del player 1
                    PlayerPrefs.SetInt("Player1", 0);
                    PlayerPrefs.SetInt("Player1Char", 1);
                }
                if(PlayerID == 1){ //Este if define el personaje y el id del player 2
                    PlayerPrefs.SetInt("Player2", 0);
                    PlayerPrefs.SetInt("Player2Char", 1);
                }
            }
            if(hit.collider.tag == "Ch2"){
                Debug.Log("Seleccionaste al personaje 2");
            }
            

        
        }



    }

}