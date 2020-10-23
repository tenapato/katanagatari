using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class RoundManager : MonoBehaviour
{
    //public int PlayerID;
    

    int winsP1;
    int winsP2;

    public Text winner;
    public GameObject pauseMenu;
    void Start()
    {
        //PlayerPrefs.SetInt("PuntosP1",0);
        //PlayerPrefs.SetInt("PuntosP2",0);
        winsP1 = PlayerPrefs.GetInt("PuntosP1", 0);
        winsP2 = PlayerPrefs.GetInt("PuntosP2", 0);

        Debug.Log("Puntos p1: " + winsP1);
        Debug.Log("Puntos p2: " + winsP2);
        pauseMenu.SetActive(false);
    }

    
    public void Points(int PlayerID)
    {
        
        //Debug.Log(PlayerID);

        if(PlayerID == 0 && winsP2 <2){
            winsP2++;
            PlayerPrefs.SetInt("PuntosP2", winsP2);
            
        }
        if(PlayerID == 1 && winsP1 < 2){
            winsP1++;
            PlayerPrefs.SetInt("PuntosP1", winsP1);
           
        }
        if(winsP1 == 2 ){
            winner.text = "P1 WINS"; 
            PlayerPrefs.SetInt("PuntosP1",0);
            PlayerPrefs.SetInt("PuntosP2",0);
            StartCoroutine(waitForMenu());
        }
        if(winsP2 == 2){
            winner.text = "P2 WINS"; 
            PlayerPrefs.SetInt("PuntosP1",0);
            PlayerPrefs.SetInt("PuntosP2",0);
            StartCoroutine(waitForMenu());
        }

        if(winsP1 != 2){
            StartCoroutine(waitForRound());
            if(winsP2 != 2){
            StartCoroutine(waitForRound());
            }
        }
        
        else{
            return;
        }
        
    }


    IEnumerator waitForRound(){
        
        yield return new WaitForSeconds(2f);
        SceneManager.LoadSceneAsync(2);

    }

    IEnumerator waitForMenu(){

        yield return new WaitForSeconds(2f);
        pauseMenu.SetActive(true);
    }
 
    
}
