using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackBtnHandler : MonoBehaviour
{
    public void Update() {

        if (Application.platform == RuntimePlatform.Android) {

            if (Input.GetKeyUp(KeyCode.Escape)) {

               Application.Quit();

               return;
           }
        }
    }
}
