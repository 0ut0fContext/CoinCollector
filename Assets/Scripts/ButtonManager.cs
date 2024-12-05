using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public GameObject pauseCanvas;

    // opens a level the button is pressed 
    public void NewLevelButn(string SampleScene)
    {
        SceneManager.LoadScene(SampleScene);
    }

    //quits the game when pressed 
    public void ExitGameButn()
    {
        Application.Quit();
    }
}
