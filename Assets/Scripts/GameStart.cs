using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{   
    public AudioSource audioBG;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("PuntosP1",0);
        PlayerPrefs.SetInt("PuntosP2",0);
        audioBG.Play();
    }

    }
