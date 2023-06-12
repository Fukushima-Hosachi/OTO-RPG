using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Controll : MonoBehaviour
{

    public Animation animation;
    public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.anyKey)
      {
        GetComponent<Animator>().SetTrigger("Tap");  
      }
      
    }
}
