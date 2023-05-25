using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

public class Chord_check : MonoBehaviour
{
    [SerializeField] Button ButtonC;
    [SerializeField] Button ButtonE;
    [SerializeField] Button ButtonG;
    [SerializeField] Button Attack;

    [SerializeField] bool C, E, G;
    [SerializeField] bool D, F, A, B;
    //Boolで管理する?←採択
    

    // Start is called before the first frame update
    void Start()
    {
       C = false;
       D = false;
       E = false;
       F = false;
       G = false;
       A = false;
       B = false;
 
    }

    // Update is called once per frame
    void Update()
    {
        //CEGが音であれば攻撃ボタンを押す
       if(C == true && E == true && G == true)
       {
            Debug.Log("Cmaj");
                 
            
            Attack.onClick.Invoke();
            C = false;
            E = false;
            G = false;
       }

       if ( D == true && F == true && A == true)
       {

            Debug.Log("Dm");

            Attack.onClick.Invoke();
            D = false;
            F = false;
            A = false;

       }

       if ( E == true && G == true && B == true)
       {

            Debug.Log("Em");

            Attack.onClick.Invoke();
            E = false;
            G = false;
            B = false;

       }

    }


    public void Chord(string chord)
    {
        if (chord == "C")
        {
            C = true;
        }

        if (chord == "D")
        {
            D = true;
        }

        if (chord == "E")
        {
            E = true;
        }

        if (chord == "F")
        {
            F = true;
        }

        if (chord == "G")
        {
            G = true;
        }

        if (chord == "A")
        {
            A = true;
        }

        if (chord == "B")
        {
            B = true;
        }

    }

    public void Onclick()
    {

    }

    //btnC.onClick.Invoke() → btnE.onClick.Invoke(); →　btnG.onClick.Invoke();の順で押されたら
   
}
