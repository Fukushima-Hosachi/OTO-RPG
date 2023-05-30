using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack_Animation : MonoBehaviour
{
    [SerializeField]  Button  Attack_Button;
    
    //public Animation AtackText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
    }

    public void onClick_Animation()
    {
        //ボタンが押されてから2秒後にボタンの色を白に変更
        GetComponent<Animator>().SetTrigger("Attack");
        Debug.Log("たぶん押されてるんでアニメーション");

    }
}
