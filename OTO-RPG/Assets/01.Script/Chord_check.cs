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
    //Boolで管理する?←採択
    

    // Start is called before the first frame update
    void Start()
    {
       C = false;
       E = false;
       G = false;
        
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

       
    }

    public void Chord(string chord)
    {
        if (chord == "C")
        {
            C = true;
        }

        if (chord == "E")
        {
            E = true;
        }

        if (chord == "G")
        {
            G = true;
        }

    }

    public void Onclick()
    {

    }

    //btnC.onClick.Invoke() → btnE.onClick.Invoke(); →　btnG.onClick.Invoke();の順で押されたら
   
}
