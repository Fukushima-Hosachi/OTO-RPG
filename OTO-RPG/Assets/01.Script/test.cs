using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    [SerializeField] private Button btnC;
    // Start is called before the first frame update
    void Start()
    {
        btnC.onClick.Invoke();
        Debug.Log("push C");
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void Onclick()
    {
        
        
       
    }
}
