using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectablesUIScript : MonoBehaviour
{
    // Initialize Variables
    public Image hammerC;
    public Image acornC;
    public Image flowerC;
    public Image flaskC;

    public Image hammerNC;
    public Image acornNC;
    public Image flowerNC;
    public Image flaskNC;

    CollectablesController collectablesControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        collectablesControllerScript = GameObject.FindWithTag("GameManager").GetComponent<CollectablesController>();

        // UI for objects collected
        // start them all as not collected
        hammerNC.enabled = true;
        hammerC.enabled = false;

        flowerNC.enabled = true;
        flowerC.enabled = false;

        flaskNC.enabled = true;
        flaskC.enabled = false;

        acornNC.enabled = true;
        acornC.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // When an object is collected switch the UI to show that it is
        if(collectablesControllerScript.obtainedAcorn == true)
        {
            acornNC.enabled = false;
            acornC.enabled = true;
        }

        if(collectablesControllerScript.obtainedFlask == true)
        {
            flaskNC.enabled = false;
            flaskC.enabled = true;
        }

        if(collectablesControllerScript.obtainedFlower == true)
        {
            flowerNC.enabled = false;
            flowerC.enabled = true;
        }

        if(collectablesControllerScript.obtainedHammer == true)
        {
            hammerNC.enabled = false;
            hammerC.enabled = true;
        }
    }
}
