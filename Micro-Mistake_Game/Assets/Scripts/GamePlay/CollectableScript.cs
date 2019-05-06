using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableScript : MonoBehaviour
{
    // Initialize Variables
    public bool collidingWithFlower;
    public bool collidingWithHammer;
    public bool collidingWithFlask;
    public bool collidingWithAcorn;

    public bool collidingWithObject;
    public string nameOfObject;

    CollectablesController collectablesManagerScript;

    AudioSource collectableAudioSource;
    public AudioClip collectedSound;

    // Start is called before the first frame update
    void Start()
    {
        collectablesManagerScript = GameObject.FindWithTag("GameManager").GetComponent<CollectablesController>();
        collectableAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // If the player is colliding with an object's area reference and they press the pick up
        // button, set that object to the they obtained state
        if (collidingWithObject == true)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(0))
            {
                if (nameOfObject == "Flower")
                {
                    collectablesManagerScript.obtainedFlower = true;
                }

                if (nameOfObject == "Hammer")
                {
                    collectablesManagerScript.obtainedHammer = true;
                }

                if (nameOfObject == "Acorn")
                {
                    collectablesManagerScript.obtainedAcorn = true;
                }

                if (nameOfObject == "Flask")
                {
                    collectablesManagerScript.obtainedFlask = true;
                }
                collectablesManagerScript.collidingWithAnObject = false;
                Destroy(this.gameObject);
            }
        }
    }

    // Checks if player can pick up item if in range
    // Used to print UI messages
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            collectableAudioSource.PlayOneShot(collectedSound);
            collectablesManagerScript.collidingWithAnObject = true;
            collidingWithObject = true;
            nameOfObject = this.gameObject.name;
        }
    }

    // Used to make UI messages go away after the player walks away or the object is picked up
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            collectablesManagerScript.collidingWithAnObject = false;
            collidingWithObject = false;
            nameOfObject = null;
        }
    }
}
