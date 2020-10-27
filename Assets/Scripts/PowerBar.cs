/* Authors
- Patricio Tena A01027293
- Rodrigo Benavente A01026973
- Fernando Garrato A01027503

    This script is used for managing the power bar of each player and when can they activate their super power
*/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerBar : MonoBehaviour
{   

    public Slider powerBar;
    public int maxValue;
    public int currentValue;
    private int count;
    private bool full;
    public bool superActivated;

    public AudioClip gettingPower1;
    public AudioClip gettingPower2;
    public AudioClip gettingPower3;
    public AudioClip gettingPower4;
    public AudioClip launchPower;

    public AudioSource audio;

    public GameObject power;
    
    public GameObject Win1;
    public GameObject Win2;
    public GameObject Win3;

    int PlayerID;
    
    int winsP1;
    int winsP2;


    // Start is called before the first frame update
    void Start()
    {   
        count = 0;
        powerBar.maxValue = maxValue;
        powerBar.value = currentValue;
        full = false;
        superActivated = false;

        winsP1 = PlayerPrefs.GetInt("PuntosP1", 0);
        winsP2 = PlayerPrefs.GetInt("PuntosP2", 0);
        int PlayerID = gameObject.GetComponent<PlayerInput>().PlayerID;
        if(PlayerID == 0){
            if(winsP1 == 0){
            Win1.SetActive(false);
            Win2.SetActive(false);
            Win3.SetActive(false);
            }
            else if(winsP1 == 1){
                Win1.SetActive(true);
                Win2.SetActive(false);
                Win3.SetActive(false);
            }
            else if(winsP1 == 2){
                Win1.SetActive(true);
                Win2.SetActive(true);
                Win3.SetActive(false);
            }
            else if(winsP1 == 3){
                Win1.SetActive(true);
                Win2.SetActive(true);
                Win3.SetActive(true);
            }
        }
        if(PlayerID == 1){
            if(winsP2 == 0){
            Win1.SetActive(false);
            Win2.SetActive(false);
            Win3.SetActive(false);
            }
            else if(winsP2 == 1){
                Win1.SetActive(true);
                Win2.SetActive(false);
                Win3.SetActive(false);
            }
            else if(winsP2 == 2){
                Win1.SetActive(true);
                Win2.SetActive(true);
                Win3.SetActive(false);
            }
            else if(winsP2 == 3){
                Win1.SetActive(true);
                Win2.SetActive(true);
                Win3.SetActive(true);
            }
        }
        


        


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        int canPlay = PlayerPrefs.GetInt("canPlay");
        if(canPlay == 1){
            if(powerBar.value >= maxValue){
                gameObject.GetComponent<PlayerInput>().canActivateSuper = true;
                power.SetActive(true);
                count++;
                if(count == 1){
                    int r = Random.Range(1, 4);
                    if(r == 1){
                        audio.PlayOneShot(gettingPower1);
                    } else if(r == 2){
                        audio.PlayOneShot(gettingPower2);
                    
                    } else if(r == 3){
                        audio.PlayOneShot(gettingPower3);
                    
                    } else if(r == 4){
                        audio.PlayOneShot(gettingPower4);
                    }
                }
                
                if(superActivated){
                    powerBar.value = 0;
                    full = false;
                    audio.PlayOneShot(launchPower);
                    gameObject.GetComponent<PlayerInput>().canActivateSuper = false;
                    power.SetActive(false);
                }



            } else if (powerBar.value < maxValue && count < 1){
                powerBar.value += Time.time;
                
            }
        }
    }
}
