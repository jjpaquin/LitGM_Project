using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] Vector3 moveDirection;
    [SerializeField] float totalMoveDistance;
    Vector3 startingLocation;

    // Start is called before the first frame update
    void Start()
    {
        startingLocation = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceTraveled = GetDoorDistanceTraveled();


        if (distanceTraveled > totalMoveDistance)
        {
            this.enabled = false;
        }

        gameObject.transform.Translate(moveDirection * moveSpeed);
    }

    float GetDoorDistanceTraveled()
    {
        return Vector3.Distance(gameObject.transform.position, startingLocation);
    }
}

