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
            Debug.Log("Cが押されたよ");
        }
        
    }
}

   
