using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidos : MonoBehaviour
{
    public AudioClip dardosound;
    AudioSource fuenteAudio;
    // Start is called before the first frame update
    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            fuenteAudio.clip = dardosound;
            fuenteAudio.Play();
        }
    }
}
