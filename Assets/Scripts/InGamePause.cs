/* Authors
- Patricio Tena A01027293
- Rodrigo Benavente A01026973
- Fernando Garrato A01027503

    This script activates the pause menu during the fight
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGamePause : MonoBehaviour
{
    public GameObject menu;


    public void Exit(){
        Application.Quit();
    }

    public void Resume(){
        GameObject [] Players = GameObject.FindGameObjectsWithTag("Player");
        menu.SetActive(false);
        Time.timeScale = 1;

        foreach (GameObject Player in Players)
        {
            PlayerInput playerInput = Player.GetComponent<PlayerInput>();
            playerInput.canPlay = 1;
            playerInput.canMove = true;
            playerInput.canJump = true;
        }
        
        

    }

    


}
