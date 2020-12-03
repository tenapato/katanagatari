/* Authors
- Patricio Tena A01027293
- Rodrigo Benavente A01026973
- Fernando Garrato A01027503

    This script is used for is used to control the main screen
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MainScreenControls : MonoBehaviour
{
    public GameObject controls;
    public GameObject credits;
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
       credits.SetActive(false);
   }
}
