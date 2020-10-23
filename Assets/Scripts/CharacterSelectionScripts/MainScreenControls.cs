using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MainScreenControls : MonoBehaviour
{
    public GameObject controls;
    public CursorControls ccontrol;
   private void Awake() {
       ccontrol = new CursorControls();
       this.ccontrol.Cursor.Circle.performed += ctx => HideControls();
   }

    private void OnEnable() {
        ccontrol.Enable();
    }

    private void OnDisable() {
        ccontrol.Disable();
    }


   public void HideControls(){
       controls.SetActive(false);
   }
}
