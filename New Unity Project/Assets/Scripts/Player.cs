using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{
    public float speed;   // Playerオブジェクトの移動速度
    Vector3 mousePos;     // 最初にタッチ(左クリック)した地点の情報を入れる



    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        // Moveメソッドを常時呼び出す
        Move();
    }

    void Move()
    {
        // マウス左クリック(画面タッチ)が行われたら
        if (Input.GetMouseButtonDown(0))
        {
            // タッチした位置を代入
            mousePos = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            // ベクトルの引き算を行い、現在のタッチ位置とその１フレーム前のタッチ位置との差分を方向として代入
            Vector3 mouseDiff = Input.mousePosition - mousePos;
            // 次のフレームのタッチ情報を計算できるように現在のタッチ位置を1フレーム前のタッチ位置として代入
            // これにより、方向の取得→更新をタッチしている間繰り返している
            mousePos = Input.mousePosition;

            // 現在のPlayerの位置に対して、タッチ位置の移動方向を使って移動先を算出する
            // 座標は画面のheightで割ることで移動位置を調整
            // タッチ情報にはZ軸の情報がないので、X軸の移動情報をX軸の移動用に使用
            Vector3 newPos = transform.position + new Vector3(0, 0, -mouseDiff.x / Screen.height) * speed;

            // Playerオブジェクトの位置を更新して移動を解決する
            transform.position = newPos;
        }
    }

}



    


