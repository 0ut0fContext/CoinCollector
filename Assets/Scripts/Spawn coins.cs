using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thing : MonoBehaviour
{
    public GameObject Coin;
    public int numberToSpawn = 10;
    public float distanceCoin = 2.0f;

    // spowns coins for the player to collect
    void Start()
    {
        for (var i = 0; i < numberToSpawn; i++)
        {
            Instantiate(Coin, new Vector3(i * distanceCoin, 0, 0), Quaternion.identity);
        }
    }
  
}
