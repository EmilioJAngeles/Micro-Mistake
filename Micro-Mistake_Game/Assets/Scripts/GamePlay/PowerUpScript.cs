using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    // Initialize Variable
    public ParticleSystem veggieEmission;

    // Play particle system when player collides with it
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            veggieEmission.Play();
        }
    }
}
