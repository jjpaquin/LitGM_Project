using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchObject : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] Vector3 moveDirection;
    [SerializeField] float totalMoveDistance;
    [SerializeField] GameObject trigger;
    Vector3 startingLocation;

    // Start is called before the first frame update
    void Start()
    {
        startingLocation = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceTraveled = GetDistanceTraveled();

        GameObject child = this.transform.GetChild(0).gameObject;

        if (distanceTraveled > totalMoveDistance)
        {
            child.GetComponent<Rigidbody>().AddForce(new Vector3(0.0f, 13.0f, 13.0f), ForceMode.Impulse);
            child.transform.parent = null;
            trigger.GetComponent<recognize_box>().enabled = false;
            trigger.GetComponent<recognize_box>().enabled = true;
            this.enabled = false;
            
        }

        gameObject.transform.Translate(moveDirection * moveSpeed);
    }

    float GetDistanceTraveled()
    {
        return Vector3.Distance(gameObject.transform.position, startingLocation);
    }
}
