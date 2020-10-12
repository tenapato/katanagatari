
/*---------------SCRIPT PARA  PROBAR LOS NUEVOS INPUTS-------------*/

/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    public Controls control;
    

    private void Awake() {
        control = new Controls();

        control.Player.Jump.performed += ctx => Jump();
        control.Player.Circle.performed += ctx => Circle();
        control.Player.Triangle.performed += ctx => Triangle();
        control.Player.Square.performed += ctx => Square();

    }

    private void OnEnable() {
        control.Enable();
    }

    private void OnDisable() {
        control.Disable();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void Jump(){
        Debug.Log("We jumped");
    }

    void Circle(){
        Debug.Log("Circle");
    }
    void Triangle(){
        Debug.Log("Triangle");
    }
    void Square(){
        Debug.Log("Square");
    }




}
 */