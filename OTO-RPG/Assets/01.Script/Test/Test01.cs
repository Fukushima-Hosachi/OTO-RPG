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
        //Debug.Log(noteName);
     
    }

     

    // Update is called once per frame
    void Update()
    {
        string noteName = pitchVisualizer.noteName;
        Debug.Log("PitchVisualizerのnoteName: " + noteName);


        if (C == true && E == true && G == true)
        {
            Debug.Log("CEGがTrueです");
            image = GetComponentInChildren<Image>();
            image.color = new Color( 0, 0, 0 ); 
        }

        if (noteName == "C")
            {
               Test_C.onClick.Invoke();
               StartCoroutine(ResetColorAfterDelay(Test_C, 2.0f));
               
            }

        if (noteName == "E")
            {
               Test_E.onClick.Invoke();
               StartCoroutine(ResetColorAfterDelay(Test_E, 2.0f));
               
            }
        
        if (noteName == "G")
            {
               Test_G.onClick.Invoke();
               StartCoroutine(ResetColorAfterDelay(Test_G, 2.0f));
               
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

    IEnumerator ResetColorAfterDelay(Button button, float delay)
    {
        yield return new WaitForSeconds(delay);

        ColorBlock colors = button.colors;
        colors.normalColor = Color.white; // 元の色に戻す色を設定
        colors.highlightedColor = Color.white; // ハイライト時の色も設定
        button.colors = colors;

        Debug.Log(button.name + "のボタン、色を元に戻しました。");
    }
}
