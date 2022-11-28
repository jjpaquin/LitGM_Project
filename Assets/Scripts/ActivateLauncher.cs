using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLauncher : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        objectToActivate.GetComponent<LaunchObject>().enabled = true;
    }

    void OnTriggerExit(Collider other)
    {
        objectToActivate.GetComponent<ResetLauncher>().enabled = true;
    }
}
