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
    void Update()
    {
        
        if(powerBar.value >= maxValue){
            gameObject.GetComponent<PlayerInput>().canActivateSuper = true;
            
            count++;
            
            if(superActivated){
                powerBar.value = 0;
                full = false;
                gameObject.GetComponent<PlayerInput>().canActivateSuper = false;
            
            }



        } else if (powerBar.value < maxValue && count < 1){
            powerBar.value += Time.time;
            
        }
    }
}
