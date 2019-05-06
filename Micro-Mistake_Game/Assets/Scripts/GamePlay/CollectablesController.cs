using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectablesController : MonoBehaviour
{
    // Initialize Variables
    public bool obtainedFlower;
    public bool obtainedFlask;
    public bool obtainedHammer;
    public bool obtainedAcorn;

    public bool obtainedAll;

    public bool collidingWithAnObject;
    public GameObject collidingWithObjectText;

    // Start is called before the first frame update
    void Start()
    {
        obtainedFlower = false;
        obtainedAcorn = false;
        obtainedFlask = false;
        obtainedHammer = false;

        obtainedAll = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Set UI text if player is in front of a collectable
        if (collidingWithAnObject == true)
        {
            collidingWithObjectText.SetActive(true);
        } else if (collidingWithAnObject == false)
        {
            collidingWithObjectText.SetActive(false);
        }

        // Game win if all objects collected
        if(obtainedAll == true)
        {
            SceneManager.LoadScene("Win");
        }

        if (obtainedFlask == true && obtainedFlower == true && obtainedHammer == true && obtainedAcorn == true)
        {
            obtainedAll = true;
        }

        if (obtainedAcorn) { Debug.Log("collected acorn"); }
        if (obtainedFlower) { Debug.Log("collected flower"); }
        if (obtainedFlask) { Debug.Log("collected flask"); }
        if (obtainedHammer) { Debug.Log("collected Hammer"); }
    }
}
