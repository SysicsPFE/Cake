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
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out hit);
            if (hit.collider != null)
            {

                if (hit.collider.tag == "dough")
                {
                    Character_Anim.SetTrigger("Trigger");
                }

            }
        }

      
    }
}
