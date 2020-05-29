using System.Collections;
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
           /* Debug.Log(col1);
            Debug.Log(col2);
            Debug.Log(col.gameObject.name );
            Debug.Log(col.gameObject.GetComponent<MeshRenderer>().material);
            Debug.Log(this.gameObject.GetComponent<MeshRenderer>().material);*/
            //col.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
            GameManagerPartie.instance.Cake_Div--;
            Debug.Log(GameManagerPartie.instance.Cake_Div);
            


        }
        
       else
        {

            Debug.Log("die");
       }
        
        
        Destroy(this.gameObject);
        if (GameManagerPartie.instance.Cake_Div == 0)
        {
            
            Debug.Log("kmel");
          
           GameManagerPartie.instance.nextCake();

           GameManagerPartie.instance.scoreValue += 10;
           
        }


    }
      
    
}
