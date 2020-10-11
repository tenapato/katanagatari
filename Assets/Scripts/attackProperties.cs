using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class attackProperties : MonoBehaviour
{

public GameObject[] hitBox;

public void resetMotion(){ //Este método resetea que puedan moverse despues de atacar
    transform.parent.gameObject.GetComponent < PlayerInput >().canMove = true;
    transform.parent.gameObject.GetComponent < PlayerInput >().canJump = true;
    transform.parent.gameObject.GetComponent < PlayerInput >().canAttack = true; //por ahora se puede atacar hasta que acabes el atque (PODER CANCERLAR DESPUES ??)
}



/*--------------------------------Estos metodos controlan la activacion de las hitboxes--------------------------------*/

public void activateHitboxHeavy(){
    hitBox[1].SetActive(true);
}

public void activateHitboxLong(){
    hitBox[0].SetActive(true);
}

public void activateHitboxShort1(){
    hitBox[2].SetActive(true);
}

public void activateHitboxShort2(){
    hitBox[3].SetActive(true);
}

public void activateHitboxShort3(){
    hitBox[4].SetActive(true);
}

public void activateHitboxJumpAttack(){
    hitBox[5].SetActive(true);
}
public void turnoffHitbox(){ //este método apaga las hitboxes
    hitBox[1].SetActive(false);
    hitBox[0].SetActive(false);
    hitBox[2].SetActive(false);
    hitBox[3].SetActive(false);
    hitBox[4].SetActive(false);
    hitBox[5].SetActive(false);
}




// para el animation event, se le manda una funcion publica
 public void activeShield(){
     print("Golpe");

    //el animation event va a llamar a este evento

 }



}
