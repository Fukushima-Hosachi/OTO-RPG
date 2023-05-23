using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset_Button : MonoBehaviour
{
    [SerializeField] private Button Base_Button, _ButtonA, _ButtonB, _ButtonC;
    public bool Button_Active;
    int argument;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //各ボタンの引数を設定してトータルの値が6になったら攻撃ボタンを押す
       
    }

    public void onClick()
    {
        //Base_Buttonが押さされたら全ボタンが白になるようにする
        _ButtonA.image.color = new Color( 255, 255, 255 ); 
        _ButtonB.image.color = new Color( 255, 255, 255 ); 
        _ButtonC.image.color = new Color( 255, 255, 255 ); 
    }
     

}

