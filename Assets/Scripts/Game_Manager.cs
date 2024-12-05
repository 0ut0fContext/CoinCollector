using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int CollectedCoin = 0;
    private bool ispaused = false;

    // adds coins to the players inventory and loads a win scene 
    public void AddCollectedCoin(int amount)
    {
        CollectedCoin += amount;

        if (CollectedCoin >= 15)
        {
            SceneManager.LoadScene("You Won!");


        }
    }
    // pauses the game 
    void Update()
    {
        Pause();
    }
    // when escape is pressed then the game spped goes to zero in order to puase the game
    void Pause()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (ispaused)
            {
                Time.timeScale = 1.0f;
            }
            else
            {
                Time.timeScale = 0.0f;
            }
            ispaused = !ispaused;
        }
    }
}
