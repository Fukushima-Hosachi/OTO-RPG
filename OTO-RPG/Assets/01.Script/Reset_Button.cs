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
        Base_Button.onClick.Invoke();
        
    }

    // Update is called once per frame
    void Update()
    {
       
       
    }

   
    public void onClick()
    {
        //ボタンが押されてから2秒後にボタンの色を白に変更
        Invoke ( "color_change", 2f );

    }

    void color_change()
    {   
        //Base_Buttonが押さされたら全ボタンが白になるようにする
        _ButtonA.image.color = new Color( 255, 255, 255 ); 
        _ButtonB.image.color = new Color( 255, 255, 255 ); 
        _ButtonC.image.color = new Color( 255, 255, 255 ); 
    }
     

}

