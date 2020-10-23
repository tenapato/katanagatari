using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
   public void Exit(){
        Application.Quit();
    }

    public void SelectCharacter(){
        SceneManager.LoadSceneAsync(1);
    }

    public void PlayAgain(){
        SceneManager.LoadSceneAsync(2);
        PlayerPrefs.SetInt("PuntosP1",0);
        PlayerPrefs.SetInt("PuntosP2",0);
    }

    public void mainMenu(){
        SceneManager.LoadScene(0);
        
    }
}
