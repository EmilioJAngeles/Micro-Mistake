using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerScript : MonoBehaviour
{
    // Initialize Variables
    public Camera poolCamera;
    public Camera thirdPerson;

    public bool inPool;

    // Start is called before the first frame update
    void Start()
    {
        // Begin with camera behind player enabled
        thirdPerson.enabled = true;
        poolCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Switch to pool camera when player in pool
        if (inPool == true)
        {
            thirdPerson.enabled = false;
            poolCamera.enabled = true;
        }
    }

}
