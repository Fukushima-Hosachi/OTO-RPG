using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Scene_Change : MonoBehaviour
{
    Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            animator.SetBool ("FadeOut", true);
            Debug.Log("FadeOut");
            Invoke ( "LoadButtle", 1.5f);
        }
    }

    void LoadTitle()
    {
        SceneManager.LoadScene("Tittle");
    }

    
    void LoadButtle()
    {
        SceneManager.LoadScene("Buttle");
        
    }

    
}
