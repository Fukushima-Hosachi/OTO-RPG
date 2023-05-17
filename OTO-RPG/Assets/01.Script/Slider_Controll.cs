using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider_Controll : MonoBehaviour
{
    GameObject monster;
    Chara_Controll script;

    // Start is called before the first frame update
    void Start()
    {
        monster = GameObject.Find ("monster");
        script = monster.GetComponent<Chara_Controll>();

        int HP = script.HP;
        int HP_Now = script.HP_Now;

        //ここからスライダーの処理
        Slider slider = GetComponent<Slider>();
        slider.minValue = 0;
        slider.maxValue = HP;
        slider.value = HP;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}