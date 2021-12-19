using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    public void ボタンまとめ(string スイッチ)
    {
        switch(スイッチ)
        {
            case "A":

                Debug.Log("Aがおされた");
                break;

            case "B":
                Debug.Log("Bがおされた");
                break;
        }
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



    }
}
