using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Controll : MonoBehaviour
{
    GameObject monster;
    Chara_Controll script;

    // Start is called before the first frame update
    void Start()
    {
        //monster = GameObject.Find ("monster");
        //script = monster.GetComponent<Chara_Controll>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Onclick()
    {
        //ボタンが押されたらキャラクターのHPが減る
        int New_HP = script.HP;
        Debug.Log( New_HP );
    }
}
