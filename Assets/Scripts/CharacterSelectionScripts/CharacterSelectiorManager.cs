using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CharacterSelectiorManager : MonoBehaviour
{   
    public GameObject P1Image;
    public GameObject P2Image;
    public GameObject P1Cursor;
    public GameObject P2Cursor;

    public int charID;


    public GameObject button;
    private void Start() {
        PlayerPrefs.DeleteKey("Player1");
        PlayerPrefs.DeleteKey("Player1Char");
        PlayerPrefs.DeleteKey("Player2");
        PlayerPrefs.DeleteKey("Player2Char");
        P1Image.SetActive(false);
        P2Image.SetActive(false);
    }
    private void Update() {
          if(PlayerPrefs.HasKey("Player1Char")){
                charID = PlayerPrefs.GetInt("Player1Char");
                P1Cursor.SetActive(false);
                if(charID == 1){
                    P1Image.SetActive(true);
                }
                if(charID == 2){
                    //Poner la imagen del otro personaje
                }
                
        }
        if(PlayerPrefs.HasKey("Player2Char")){
                P2Cursor.SetActive(false);
                charID = PlayerPrefs.GetInt("Player1Char");
                if(charID == 1){
                    P2Image.SetActive(true);
                }
                if(charID == 2){
                    //Poner la imagen del otro personaje
                }
        
        }
        if(PlayerPrefs.HasKey("Player1Char") && PlayerPrefs.HasKey("Player2Char")){
            button.SetActive(true);
        }
        if(PlayerPrefs.HasKey("Player1Char") == false){
                P1Cursor.SetActive(true);
               
        }
    }
}
