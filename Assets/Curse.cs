using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curse : MonoBehaviour
{
    public GameObject ParticleSystem;

    void Start()
    {
        ParticleSystem.GetComponent<ParticleSystem>().Stop();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>()!= null)
        {
            ParticleSystem.GetComponent<ParticleSystem>().Play();
            other.GetComponent<PlayerMovement>().ScrambleKeys();
        }
    }
}
