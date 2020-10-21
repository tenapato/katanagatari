using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusic : MonoBehaviour
{
    Scene scene;
    public bool play = true;
    private static BackgroundMusic instance = null;
    public static BackgroundMusic Instance{
        get { return instance;}
    }
    private void Awake() {
        //GameObject[] musicObj = GameObject.FindGameObjectsWithTag("BgMusic");

        if(instance != null && instance != this){
            Destroy(this.gameObject);
            return;
        }  else{
            instance = this;
        }  
        DontDestroyOnLoad(this.gameObject);
    }

   /* private void Start() {
        scene = SceneManager.GetActiveScene();
    }*/
}
