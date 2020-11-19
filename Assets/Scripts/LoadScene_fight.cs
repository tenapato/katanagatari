/* Authors
- Patricio Tena A01027293
- Rodrigo Benavente A01026973
- Fernando Garrato A01027503

    This script is used for loading the fight scene and displaying a loading bar
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene_fight : MonoBehaviour
{
    // Start is called before the first frame update
   /* void Start()
    {
        GetComponent<Button>().onClick.AddListener(LoadLevel);
    } */

  /*  void LoadScenes(){
        SceneManager.LoadScene("fightScene");
    }*/
    public GameObject loadingScreen;
    public Slider slider;
    public Text progressText;
    public GameObject characterSelectScene;
    public GameObject StageSelectionScene;
    public void LoadLevel (int sceneIndex){
        
        
        StartCoroutine(LoadAsynchrounously(sceneIndex));

    }

    IEnumerator LoadAsynchrounously(int sceneIndex){
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        StageSelectionScene.SetActive(false);
        characterSelectScene.SetActive(false);
        
        
        loadingScreen.SetActive(true);
        while(!operation.isDone){
           // float progress = Mathf.Clamp01(operation.progress);
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progress;
            progressText.text = progress * 100f + "%";
            yield return null;
        }
    }




}
