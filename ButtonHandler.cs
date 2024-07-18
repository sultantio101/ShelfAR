using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public void QuitButton()
    {
        Application.Quit();
    }

    public void ScanButton()
    {
        SceneManager.LoadScene("Scan");
    }

    public void HTUButton()
    {
        SceneManager.LoadScene("How to Use");
    }

    public void AboutUsButton()
    {
        SceneManager.LoadScene("About Us");
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Update() {

        if (Application.platform == RuntimePlatform.Android) {

            if (Input.GetKeyUp(KeyCode.Escape)) {

               SceneManager.LoadScene("Menu");

               return;
           }
        }
    }
}