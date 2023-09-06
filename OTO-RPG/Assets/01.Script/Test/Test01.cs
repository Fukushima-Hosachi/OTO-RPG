using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Test01 : MonoBehaviour
{
    //C,G,Eのボタンが押されたら色を変えるスクリプト
    // Start is called before the first frame update

    public Button Test_C;
    public Image image; 

    private Color originalColor;
        
    void Start()
    {

    }

     

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CEGButton ( int num )
    {
        switch (num)
        {
            case 1 :
                    Debug.Log("Cのボタン、テストスクリプト");
                    Test_C = GetComponent<Button>();
                    image = GetComponentInChildren<Image>();
                    image.color = new Color( 255, 0, 0 ); 

                    break;

            case 2 :
                    Debug.Log("Eのボタン、テストスクリプト");
                    break;
            
            case 3 :
                    Debug.Log("Gのボタン、テストスクリプト");
                    break;
        }
    }
}
