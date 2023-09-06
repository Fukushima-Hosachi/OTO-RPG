using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test01 : MonoBehaviour
{
    //C,G,Eのボタンが押されたら色を変えるスクリプト
    // Start is called before the first frame update
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
