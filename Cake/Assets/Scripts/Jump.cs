using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpSpeed = 20f;
    public bool inGround = true;
    
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionStay()
    {
        inGround = true;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * jumpSpeed;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * jumpSpeed;

        if (Input.GetKeyDown("space") && inGround)
        {
            rb.AddForce(new Vector3(0f,2f,0f)* jumpSpeed, ForceMode.Impulse);
            inGround = false;
        }
    }
}
