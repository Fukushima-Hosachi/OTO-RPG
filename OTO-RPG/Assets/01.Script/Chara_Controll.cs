using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara_Controll : MonoBehaviour
{
    public int HP;
    public int MaxDamage;
    public int minDamage;
    public int Damage;

    // Start is called before the first frame update
    void Start()
    {
        
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

        if ( HP <= 0 )
        {
            Destroy (this.gameObject);
        }
        
    }
    
}
