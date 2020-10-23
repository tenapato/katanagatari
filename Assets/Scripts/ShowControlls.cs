using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowControlls : MonoBehaviour
{   
    public GameObject controls;
    private void Start() {
        controls.SetActive(false);
    }
    public void Controls(){
        controls.SetActive(true);
    }
}
