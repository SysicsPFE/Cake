using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_Jump : MonoBehaviour
{
    public Animator Character_Anim;

    void Start()
    {
        Character_Anim = GetComponent<Animator>();
    }

   

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {  
             Character_Anim.SetTrigger("Trigger");
            
        }
    }
}
