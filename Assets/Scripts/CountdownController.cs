/* Authors
- Patricio Tena A01027293
- Rodrigo Benavente A01026973
- Fernando Garrato A01027503

    This script is used for manangin the inical countdown and timer of each round
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownController : MonoBehaviour
{

    public int countdownTime;
    public Text countdownDisplay;
    public int startTime;
    public Text startDisplay;
    public GameObject goDisplay;

    


    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("canPlay", 0);
        PlayerPrefs.SetInt("lostByTime", 0);
        StartCoroutine(startTimer());
        
       
        
    }

    IEnumerator roundTimer(){
        while(countdownTime > 0){
            countdownDisplay.text = countdownTime.ToString();
            
            yield return new WaitForSeconds(1f);
            goDisplay.SetActive(false);
            
            countdownTime--;
        }
        if(countdownTime <= 0){
            PlayerPrefs.SetInt("canPlay", 0);
            PlayerPrefs.SetInt("lostByTime", 1);
        }
    }
    
    IEnumerator startTimer(){
        while (startTime > 0)
        {
            startDisplay.text = startTime.ToString();

            yield return new WaitForSeconds(1f);

            startTime--;
        }

        if(startTime <= 1){
            
            startDisplay.text = "GO!";
            //startDisplay.SetActive(false);
            goDisplay.SetActive(true);
            PlayerPrefs.SetInt("canPlay", 1);
            StartCoroutine(roundTimer());
            
        }
    }
}
