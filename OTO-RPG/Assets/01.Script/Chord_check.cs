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

    [SerializeField] bool C, E, G;
    //1,3,5ならCmajとか2,4,6ならDmとか
    //Boolで管理する?
    

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
       
    }

    public void Chord(string chord)
    {
        if (chord == "C")
        {
            C = true;
            Debug.Log("this is C");
        }

        if (chord == "E")
        {
            E = true;
            Debug.Log("this is E");
        }

        if(C == true && E == true)
        {
            Debug.Log("Cmaj");
        }
    }

    //btnC.onClick.Invoke() → btnE.onClick.Invoke(); →　btnG.onClick.Invoke();の順で押されたら
   
}
