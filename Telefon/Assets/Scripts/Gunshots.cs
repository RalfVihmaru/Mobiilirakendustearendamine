using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunshots : MonoBehaviour
{
    public AudioClip audio;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audioSource.enabled = true;

                audioSource.clip = audio;
                audioSource.Play();
                Debug.Log("playing audio");
         
        }
    }
}
