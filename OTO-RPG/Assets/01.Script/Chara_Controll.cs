using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chara_Controll : MonoBehaviour
{
    public int HP;
    public int MaxDamage;
    public int minDamage;
    public int Damage;
    public int HP_Now;
    
    public Slider slider;	

    // Start is called before the first frame update
    void Start()
    {
        Slider slider = GetComponent<Slider>();
        slider.minValue = 0;
        slider.maxValue = HP;
        slider.value = HP;
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    public void Onclick()
    {
        //ボタンが押されたらキャラクターのHPが減る
        int Damage = (Random.Range(MaxDamage,minDamage));

        HP = HP - Damage;
        Debug.Log( "ダメージは" + Damage + "残りHPは" + HP );

        slider.value = HP;

        if ( HP <= 0 )
        {
            Destroy (this.gameObject);
        }
        
    }
    
}
