﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collision : MonoBehaviour
{
    static  int counter=0;
    public GameObject cake;
    
    

    private int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
        
    }

   void OnTriggerEnter(Collider col)
    {   
        //Debug.Log(this.gameObject.GetComponent<MeshRenderer>().material);
        Color col1 = this.gameObject.GetComponent<MeshRenderer>().materials[0].GetColor("_BaseColor");
        Color col2 = col.gameObject.GetComponent<MeshRenderer>().materials[0].GetColor("_BaseColor");
        

        if (col1==col2 && col.gameObject.tag == "Cake")
        {
            
            col2.a = 1;
            col.gameObject.GetComponent<MeshRenderer>().material.SetColor("_BaseColor", col2);
        
            GameManagerPartie.instance.Cake_Div--;
            Debug.Log(GameManagerPartie.instance.Cake_Div);
            


        }
        
       else
        {

            Debug.Log("die");
            GameManagerPartie.instance.Die = true;
            
       }
        
        
        Destroy(this.gameObject);
        if (GameManagerPartie.instance.Cake_Div == 0)
        {
            
            Debug.Log("kmel");
           
             

            switch (GameManagerPartie.instance.Mode)
            {
                case "Endless":
                    GameManagerPartie.instance.nextCake();
                    break;

                case "Timer":

                    Timer.timeLeft = 50f;
                    GameManagerPartie.instance.nextCake();
                    
                    break;

                case "Speed":

                    Debug.Log("5tart speed");
                    GameManagerPartie.instance.nextCake();
                    break;
            }
            //GameManagerPartie.instance.nextCake();
            GameManagerPartie.instance.scoreValue += 10;
           
        }
       


    }
      
    
}
