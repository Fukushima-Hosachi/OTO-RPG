using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara_Controll : MonoBehaviour
{
    public int HP;
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
        HP = HP - Damage;
        Debug.Log( HP );

        if ( HP <= 0 )
        {
            Destroy (this.gameObject);
        }
        
    }
    
}
