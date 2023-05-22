using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class Chord_check : MonoBehaviour
{
    //1,3,5ならCmajとか2,4,6ならDmとか
    //Boolで管理する?
    public int Chord_num;
    bool CM;

    // Start is called before the first frame update
    void Start()
    {
        Chord_num = 0;
        CM = false;

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            Chord_num = 1;
        }

        Debug.Log( Chord_num );

        //1，3，5，の順番で押されたらCmaj
    }

    void Cmaj()
    {

    }

    //btnC.onClick.Invoke() → btnE.onClick.Invoke(); →　btnG.onClick.Invoke();の順で押されたら
   
}
