/* Authors
- Patricio Tena A01027293
- Rodrigo Benavente A01026973
- Fernando Garrato A01027503

    This script is used for controllng each player cursor, creates a raycast to know which character is going to be selected and deselecting charactes
*/


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
    public AudioSource audio;
    

    
    

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
        this.ccontrol.Cursor.Circle.performed += ctx => DeSelectCharacter();

       
    }
    private void OnEnable() {
        ccontrol.Enable();
    }

    private void OnDisable() {
        ccontrol.Disable();
    }

    
    public void SelectCharacter(){
       
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.up), 15.0f);
       // Debug.DrawRay(transform.position, Vector2.up, Color.green);
        if(hit){
        
        //Debug.Log("Hit: " + hit.collider.tag);
            
            if(hit.collider.tag == "Ch1"){
                Debug.Log("Seleccionaste al personaje 1");
                if(PlayerID == 0){ //Este if define el personaje y el id del player 1
                    PlayerPrefs.SetInt("Player1", 1);
                    PlayerPrefs.SetInt("Player1Char", 1);
                    audio.Play();
                }
                if(PlayerID == 1){ //Este if define el personaje y el id del player 2
                    PlayerPrefs.SetInt("Player2", 1);
                    PlayerPrefs.SetInt("Player2Char", 1);
                    audio.Play();
                }
            }
            if(hit.collider.tag == "Ch2"){
                Debug.Log("Seleccionaste al personaje 2");
                if(PlayerID == 0){ //Este if define el personaje y el id del player 1
                    PlayerPrefs.SetInt("Player1", 0);
                    PlayerPrefs.SetInt("Player1Char", 2);
                }
                if(PlayerID == 1){ //Este if define el personaje y el id del player 2
                    PlayerPrefs.SetInt("Player2", 1);
                    PlayerPrefs.SetInt("Player2Char", 2);
                }
            }
            


            if(hit.collider.tag == "Stg1"){
                Debug.Log("Seleccionaste la pista 1");
                PlayerPrefs.SetInt("StageIndex", 1);
            }

        
        }
    
    }


    public void DeSelectCharacter(){
        
       // Debug.Log("Presionado");
        
        if(PlayerPrefs.HasKey("Player1Char")){
           // gameObject.GetComponent<CharacterSelectiorManager>().P1Cursor.SetActive(true);
            PlayerPrefs.DeleteKey("Player1");
            PlayerPrefs.DeleteKey("Player1Char");
            PlayerPrefs.DeleteKey("StageIndex");
            //gameObject.GetComponent<CharacterSelectiorManager>().hasSelectedBefore = true;
            
        }
        if(PlayerPrefs.HasKey("Player2Char")){
            PlayerPrefs.DeleteKey("Player2");
            PlayerPrefs.DeleteKey("Player2Char");
            PlayerPrefs.DeleteKey("StageIndex");
        } 
    } 



}