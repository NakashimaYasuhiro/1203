using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallJump : MonoBehaviour
{
    public float jumppowr;
    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetMouseButton(0))
        {
            Debug.Log("Hit");
            rb.velocity = Vector3.up * jumppowr;
        }
        
    }
}
