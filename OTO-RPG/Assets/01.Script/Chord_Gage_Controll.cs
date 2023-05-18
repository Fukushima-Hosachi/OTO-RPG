using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chord_Gage_Controll : MonoBehaviour
{
    public Button button;	   
    public Image image; 
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Onclick()
    { 
       button = GetComponent<Button>();
       image = GetComponentInChildren<Image>();
       image.color = new Color( 255, 0, 0 ); 

       Debug.Log("C");
       
    }
}
