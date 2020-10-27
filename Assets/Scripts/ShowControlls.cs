/* Authors
- Patricio Tena A01027293
- Rodrigo Benavente A01026973
- Fernando Garrato A01027503

    This script is used for managing the buttons of the main screen
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowControlls : MonoBehaviour
{   
    public GameObject controls;
    public GameObject credits;
    private void Start() {
        controls.SetActive(false);
        credits.SetActive(false);
    }
    public void Controls(){
        controls.SetActive(true);
    }
    public void Credits(){
        credits.SetActive(true);
    }
}
