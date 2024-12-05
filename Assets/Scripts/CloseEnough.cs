using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseEnough : MonoBehaviour
{
    public Transform player;
    public float DetectionDistance = 5.0f;

    // will check if the player is close enough usuefull for telling whne the player is close enough to an object to pick it up or too close to a wall
    void Update()
    {
        float DistanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (DistanceToPlayer <= DetectionDistance)
        {
            Debug.Log("player is close enough");
        }

    }
}
