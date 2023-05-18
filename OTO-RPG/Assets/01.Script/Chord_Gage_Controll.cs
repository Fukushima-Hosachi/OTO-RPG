using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chord_Gage_Controll : MonoBehaviour
{
    public Button button;	
    public Button button02;
   
    public Image image; 
    public Image image02;
    public AudioClip C, E, G;
    public AudioSource audioSource;

    [SerializeField] Button btnC;
    [SerializeField] Button btnE;
    [SerializeField] Button btnG;

    
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>();
        //button = GetComponentInChildren<Button>();
        //image = GetComponentInChildren<Image>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            audioSource.PlayOneShot(C);

            
            btnC.onClick.Invoke();
            Debug.Log("tag C");
            //Onclick_C();
            
            
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            audioSource.PlayOneShot(E);

               btnE.onClick.Invoke(); 
               Debug.Log("tag E");
               //Onclick_E(); 
              
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            audioSource.PlayOneShot(G);

               btnG.onClick.Invoke(); 
               Debug.Log("tag G");
               //Onclick_E(); 
              
        }
    }

    public void Onclick_C()
    {
        
        button = GetComponent<Button>();
        image = GetComponentInChildren<Image>();
        image.color = new Color( 255, 0, 0 ); 

    }
    
    public void Onclick_E()
    {
        button02 = GetComponent<Button>();
        image = GetComponentInChildren<Image>();
        image.color = new Color( 0, 255, 0 ); 
        Debug.Log("E");

    }

    public void Onclick_G()
    {
        button02 = GetComponent<Button>();
        image = GetComponentInChildren<Image>();
        image.color = new Color( 0, 0, 255 ); 
        Debug.Log("E");

    }
       
}



