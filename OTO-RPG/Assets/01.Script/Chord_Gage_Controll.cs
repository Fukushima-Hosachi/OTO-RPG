using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chord_Gage_Controll : MonoBehaviour
{
    public Button button;	
    
   
    public Image image; 
    public AudioClip C;
    public AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>();
        button = GetComponentInChildren<Button>();
        image = GetComponentInChildren<Image>();
      
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Onclick();
        }
    }

    public void Onclick()
    {
        audioSource.PlayOneShot(C);

        if (button.CompareTag("C")) 
       {

        button = GetComponent<Button>();
        image = GetComponentInChildren<Image>();
        image.color = new Color( 255, 0, 0 ); 

       }
    }

    public void Onclick_C()
    { 
       if (button.CompareTag("C")) 
       {

        button = GetComponent<Button>();
        image = GetComponentInChildren<Image>();
        image.color = new Color( 255, 0, 0 ); 

       }
            
    }

    
}


