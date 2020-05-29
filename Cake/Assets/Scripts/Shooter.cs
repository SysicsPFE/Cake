using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    GameObject prefab;
    public Transform firePoint;
    //public Animator Character_Anim;

    void Start()
    {
        prefab = Resources.Load("Shoot") as GameObject;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            GameObject Shoot = Instantiate(prefab) as GameObject;
           
            Shoot.transform.position = firePoint.position;
            Rigidbody rb = Shoot.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 400;
        }
          
    }
}
