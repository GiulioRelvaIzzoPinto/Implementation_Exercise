using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioStop : MonoBehaviour
{
    public AudioSource AudioSource1;
    public AudioSource AudioSource2;
    public float maxDistance = 0.8f;
    public float minDistance = 0.2f;

    void Start()
    {
        AudioSource1.Play();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (AudioSource1.isPlaying)
            {
                AudioSource1.maxDistance = maxDistance;
                AudioSource1.Stop();
                AudioSource1.minDistance -= minDistance;
                AudioSource2.Play();
            }

            else if (AudioSource2.isPlaying)
            {
                AudioSource2.maxDistance = maxDistance;
                AudioSource2.Stop();
                AudioSource1.minDistance -= minDistance;
                AudioSource1.Play();
            }

            else return;
            {
                AudioSource1.Play();
            }
        }
    }

}
