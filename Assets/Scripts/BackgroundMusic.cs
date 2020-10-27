/* Authors
- Patricio Tena A01027293
- Rodrigo Benavente A01026973
- Fernando Garrato A01027503

    This script is used for managing the music of the main screen and the character select screen
*/

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
