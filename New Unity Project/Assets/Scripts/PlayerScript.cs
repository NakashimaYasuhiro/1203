using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{    public FloatingJoystick inputMove; //�����JoyStick
    public FloatingJoystick inputRotate; //�E���JoyStick
    float moveSpeed = 5.0f; //�ړ����鑬�x
    float rotateSpeed = 5.0f;  //��]���鑬�x
    // Start is called before the first frame update
    void Start()
    {


}

    // Update is called once per frame
    void Update()
    {
        //���X�e�B�b�N�ł̏c�ړ�
        this.transform.position += this.transform.forward * inputMove.Vertical * moveSpeed * Time.deltaTime;
        //���X�e�B�b�N�ł̉��ړ�
        this.transform.position += this.transform.right * inputMove.Horizontal * moveSpeed * Time.deltaTime;
        //�E�X�e�B�b�N�ł̉�]
        transform.Rotate(new Vector3(0, rotateSpeed * inputRotate.Horizontal, 0));

    }
}
