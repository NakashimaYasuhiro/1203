using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttonleft : MonoBehaviour
{
    public GameObject button;
    public GameObject ball;//ボールの変数
    // Start is called before the first frame update
    void Start()
    {
        button.SetActive(false);

        //Sphereオブジェクトを格納
        ball = GameObject.Find("Cube(Rotate)");
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "button")
        {
            button.SetActive(true);
        }
    }
    //SphereのY座標を5にする
    public void BallUp()
    {
        ball.transform.Rotate(0, -50, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Click()
    {

        transform.Rotate(0, 50 * Time.deltaTime, 0);
        //ログ出力
        Debug.Log("押したよ！");
    }
}
