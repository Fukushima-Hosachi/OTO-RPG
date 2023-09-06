using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Test01 : MonoBehaviour
{
    //C,G,Eのボタンが押されたら色を変えるスクリプト
    // Start is called before the first frame update

    public Button Test_C, Test_E, Test_G;
    private bool C,E,G;
    public Image image; 

    public PitchVisualizer pitchVisualizer;
        
    void Start()
    {
        string noteName = pitchVisualizer.noteName;
        Debug.Log("PitchVisualizerのnoteName: " + noteName);
        
        C = false;
        E = false;
        G = false;
      
    }

     

    // Update is called once per frame
    void Update()
    {
        if (C == true && E == true && G == true)
        {
            Debug.Log("CEGがTrueです");
        }
    }

    public void CEGButton ( int num )
    {
        switch (num)
        {
            case 1 :
                    //Debug.Log("Cのボタン、テストスクリプト");
                    C = true;
                    Test_C = GetComponent<Button>();
                    image = GetComponentInChildren<Image>();
                    image.color = new Color( 255, 0, 0 ); 
                    
                    Debug.Log("CをTrueにしました");

                    break;

            case 2 :
                    //Debug.Log("Eのボタン、テストスクリプト");
                    E = true;
                    Test_E = GetComponent<Button>();
                    image = GetComponentInChildren<Image>();
                    image.color = new Color( 255, 0, 0 ); 
                    Debug.Log("EをTrueにしました");

                    break;
            
            case 3 :
                    //Debug.Log("Gのボタン、テストスクリプト");
                    G = true;
                    Test_G = GetComponent<Button>();
                    image = GetComponentInChildren<Image>();
                    image.color = new Color( 255, 0, 0 ); 
                    Debug.Log("GをTrueにしました");

                    break;
        }
        
    }
}
