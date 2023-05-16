using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource audioSource;


    public AudioClip C,D,E,F,G,A,B;
    

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.C))
        {
            audioSource.PlayOneShot(C);
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            audioSource.PlayOneShot(D);
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            audioSource.PlayOneShot(E);
        }
        if(Input.GetKeyDown(KeyCode.F))
        {
            audioSource.PlayOneShot(F);
        }
        if(Input.GetKeyDown(KeyCode.G))
        {
            audioSource.PlayOneShot(G);
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            audioSource.PlayOneShot(A);
        }
        if(Input.GetKeyDown(KeyCode.B))
        {
            audioSource.PlayOneShot(B);
        }
    }
}

   
