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
        ParticleSystem.GetComponent<ParticleSystem>().Play();
        Debug.Log("CURSE");
    }
}
