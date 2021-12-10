using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// メイン
public class Main : MonoBehaviour
{
    public FixedJoystick joystick;

    // 更新時に呼ばれる
    void Update()
    {
        // ジョイスティックの状態表示
        print("Horizontal: " + joystick.Horizontal);
        print("Vertical: " + joystick.Vertical);
    }
}
