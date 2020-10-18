  
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

        if(characterIsSelected){
            Debug.Log("Seleccionaste a tu personaje");
        }
        
    }

}