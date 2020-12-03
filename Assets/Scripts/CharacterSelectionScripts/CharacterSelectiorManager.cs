/* Authors
- Patricio Tena A01027293
- Rodrigo Benavente A01026973
- Fernando Garrato A01027503

    This script handles the character selection of each player as well as the deselction of a cheracter
*/


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

    public Transform P1CursorWhenCharacterIsSelected;
    public Transform P1CursorWhenCharacterIsDeSelected;
    public Transform P2CursorWhenCharacterIsSelected;
    public Transform P2CursorWhenCharacterIsDeSelected;

    public int count = 0;
    public int count2 = 0;

    public int charID;

    public bool hasSelectedBefore = false;

    public GameObject ready;

    public GameObject selectP1;
    public GameObject cancelP1;
    public GameObject selectP2;
    public GameObject cancelP2;
    public AudioClip gettingSelected;

    public GameObject stageSelection;
    
    public GameObject [] BackGrounds;
    
    int stage;




    private void Start() {
        PlayerPrefs.DeleteKey("Player1");
        PlayerPrefs.DeleteKey("Player1Char");
        PlayerPrefs.DeleteKey("Player2");
        PlayerPrefs.DeleteKey("Player2Char");
        PlayerPrefs.DeleteKey("StageIndex");
        P1Image.SetActive(false);
        P2Image.SetActive(false);
        selectP1.SetActive(true);
        cancelP1.SetActive(false);
        selectP2.SetActive(true);
        cancelP2.SetActive(false);
        stageSelection.SetActive(false);
        BackGrounds[0].SetActive(true);
       
    }
    private void Update() {
          if(PlayerPrefs.HasKey("Player1Char")){
                
                charID = PlayerPrefs.GetInt("Player1Char");
                //audio.PlayOneShot(gettingSelected);
                
                count = 1;
                
                selectP1.SetActive(false);
                cancelP1.SetActive(true);
                
                //P1Cursor.SetActive(false);
                P1Cursor.transform.position = P1CursorWhenCharacterIsSelected.transform.position;

                if(charID == 1){
                    P1Image.SetActive(true);
                    
                }
                if(charID == 2){
                    //Poner la imagen del otro personaje
                }
                
        }
        if(PlayerPrefs.HasKey("Player2Char")){
                count2 = 1;
                
                selectP2.SetActive(false);
                cancelP2.SetActive(true);
                P2Cursor.transform.position = P2CursorWhenCharacterIsSelected.transform.position;
                charID = PlayerPrefs.GetInt("Player2Char");
                if(charID == 1){
                    P2Image.SetActive(true);
                    
                }
                if(charID == 2){
                    //Poner la imagen del otro personaje
                }
        
        }
        if(PlayerPrefs.HasKey("Player1Char") && PlayerPrefs.HasKey("Player2Char")){
            //ready.SetActive(true);
            stageSelection.SetActive(true);
            BackGrounds[0].SetActive(true);
       
        }
        if(!PlayerPrefs.HasKey("Player1Char") && count > 0){
            P1Cursor.transform.position = P1CursorWhenCharacterIsDeSelected.transform.position;
            
            P1Image.SetActive(false);
            selectP1.SetActive(true);
            cancelP1.SetActive(false);
            count = 0;
            ready.SetActive(false);
            stageSelection.SetActive(false);
         
        }
        if(!PlayerPrefs.HasKey("Player2Char") && count2 > 0){
            P2Cursor.transform.position = P2CursorWhenCharacterIsDeSelected.transform.position;
            P2Image.SetActive(false);
            selectP2.SetActive(true);
            cancelP2.SetActive(false);
            count2 = 0;
            ready.SetActive(false);
            stageSelection.SetActive(false);
           
        }


        if(PlayerPrefs.HasKey("StageIndex")){
            stage = PlayerPrefs.GetInt("StageIndex");
            BackGrounds[0].SetActive(false);
            BackGrounds[stage].SetActive(true);
            ready.SetActive(true);


        }else{
            BackGrounds[0].SetActive(true);
            BackGrounds[stage].SetActive(false);
        }


        


    }
}
