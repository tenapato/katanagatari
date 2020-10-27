/* Authors
- Patricio Tena A01027293
- Rodrigo Benavente A01026973
- Fernando Garrato A01027503

    This script is used for managing the game on start and sets some variables
*/

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
