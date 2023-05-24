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
    public AudioClip D, F, A, B;
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
            
            
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            audioSource.PlayOneShot(D);
            //btnC.onClick.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            audioSource.PlayOneShot(E);

               btnE.onClick.Invoke(); 
               
              
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            audioSource.PlayOneShot(F);
            //btnC.onClick.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            audioSource.PlayOneShot(G);

               btnG.onClick.Invoke(); 
               Debug.Log("tag G");
               //Onclick_E(); 
              
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            audioSource.PlayOneShot(A);
            //btnC.onClick.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            audioSource.PlayOneShot(B);
            //btnC.onClick.Invoke();
        }
    }

    public void Onclick_C()
    {
        
        button = GetComponent<Button>();
        image = GetComponentInChildren<Image>();
        image.color = new Color( 255, 0, 0 ); 

    }
    
    public void Onclick_D()
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
        
    }

    public void Onclick_F()
    {
        
        button = GetComponent<Button>();
        image = GetComponentInChildren<Image>();
        image.color = new Color( 255, 0, 0 ); 

    }

    public void Onclick_G()
    {
        button02 = GetComponent<Button>();
        image = GetComponentInChildren<Image>();
        image.color = new Color( 0, 0, 255 ); 
    

    }

    public void Onclick_A()
    {
        
        button = GetComponent<Button>();
        image = GetComponentInChildren<Image>();
        image.color = new Color( 255, 0, 0 ); 

    }
       
}



