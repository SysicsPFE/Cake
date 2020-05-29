using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    byte degreesPerSecond = 55;
    Renderer Cake;

    void start()
    {

        Cake = GetComponent<Renderer>();
        Color color = Cake.material.color;
        color.a += 0.5f;
        Cake.material.color = color;
        

    }
   
    void Update()
    {
        transform.Rotate(Vector3.up * degreesPerSecond * Time.deltaTime, Space.Self);
    }
}
