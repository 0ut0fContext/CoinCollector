using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collection : MonoBehaviour
{
    // on collion with a player tag it will be 
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager gameManager = FindAnyObjectByType<GameManager>();
            if (gameManager != null)
            {
                gameManager.AddCollectedCoin(1);
            }
            Destroy(gameObject);
        }
    }
}
