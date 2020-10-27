/* Authors
- Patricio Tena A01027293
- Rodrigo Benavente A01026973
- Fernando Garrato A01027503

    This script is used for managing the rounds each player was won and loanding the final menu
*/



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

    public int numberOfRounds;
    

    
    void Start()
    {
        //PlayerPrefs.SetInt("PuntosP1",0);
        //PlayerPrefs.SetInt("PuntosP2",0);
        winsP1 = PlayerPrefs.GetInt("PuntosP1", 0);
        winsP2 = PlayerPrefs.GetInt("PuntosP2", 0);

        Debug.Log("Puntos p1: " + winsP1);
        Debug.Log("Puntos p2: " + winsP2);
        pauseMenu.SetActive(false);
        //winsP1text.setActive(false);
        //winsP2text.setActive(false);
       
        

        
    }


    public void Points(int PlayerID)
    {
        if(PlayerID == 0 && winsP2 <numberOfRounds){
            winsP2++;
            PlayerPrefs.SetInt("PuntosP2", winsP2);     
        }
        if(PlayerID == 1 && winsP1 < numberOfRounds){
            winsP1++;
            PlayerPrefs.SetInt("PuntosP1", winsP1);
        }
        if(winsP1 == numberOfRounds){
            winner.text = "P1 WINS"; 
            PlayerPrefs.SetInt("PuntosP1",0);
            PlayerPrefs.SetInt("PuntosP2",0);
            PlayerPrefs.SetInt("canPlay", 0);
            StartCoroutine(waitForMenu());
        }
        else if(winsP2 == numberOfRounds){
            winner.text = "P2 WINS"; 
            PlayerPrefs.SetInt("PuntosP1",0);
            PlayerPrefs.SetInt("PuntosP2",0);
            PlayerPrefs.SetInt("canPlay", 0);
            StartCoroutine(waitForMenu());
        }
        else{
            StartCoroutine(waitForRound());
            
        }
        
    }


    IEnumerator waitForRound(){
        
        //winsP1text.setActive(true);
        //winsP2text.setActive(true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadSceneAsync(2);

    }

    IEnumerator waitForMenu(){

        yield return new WaitForSeconds(2f);
        pauseMenu.SetActive(true);
    }
 
    
}
