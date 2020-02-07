using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControl : MonoBehaviour
{
   
    Material m;
     //public string currentColor;
     public GameObject player;
     
    

    void Start()
    {
        m = GetComponent<Renderer>().material;
        
    }

   
    void OnMouseDown()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("mcha");
            player.GetComponent<Renderer>().material = m; }
    }
   }

