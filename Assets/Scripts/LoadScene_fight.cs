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

    public void LoadLevel (int sceneIndex){
        
        
        StartCoroutine(LoadAsynchrounously(sceneIndex));

    }

    IEnumerator LoadAsynchrounously(int sceneIndex){
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        characterSelectScene.SetActive(false);
        loadingScreen.SetActive(true);
        while(!operation.isDone){
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            progressText.text = progress * 100f + "%";
            yield return null;
        }
    }




}
