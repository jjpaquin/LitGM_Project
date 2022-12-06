using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class recognize_box : MonoBehaviour
{
    [SerializeField] GameObject Launcher;

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
        other.transform.parent = Launcher.transform;
    }

    void OnTiggerExit(Collider other)
    {
        other.transform.parent = null;
    }
}
