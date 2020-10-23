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
    
    



    // Start is called before the first frame update
    void Start()
    {   
        count = 0;
        powerBar.maxValue = maxValue;
        powerBar.value = currentValue;
        full = false;
        superActivated = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
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
