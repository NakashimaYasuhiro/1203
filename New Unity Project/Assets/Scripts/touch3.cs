using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch3 : MonoBehaviour

    
{ public float JumpPowr;
    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();    
        
    }

    // Update is called once per frame
    void Update()
    {
          if (Input.GetKeyDown(KeyCode.Space))

        {
            Debug.Log("getmousebutton");
            rb.velocity = Vector3.up * JumpPowr;
           // Application.OpenURL("https://www.youtube.com/watch?v=vbpEHC9Td8w&t=297s");//""の中には開きたいWebページのURLを入力します
        }

    }



}
