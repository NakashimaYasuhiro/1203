
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class joystickMobile : MonoBehaviour
{
    protected Joystick joystick;
    private Transform firstPos;

    private void Start()
    {
        joystick = FindObjectOfType<Joystick>();
    }

    private void Update()
    {
        Vector3 velocity = gameObject.transform.rotation * new Vector3(joystick.Horizontal * 1.5f, 0, joystick.Vertical * 1.5f);
        gameObject.transform.position += velocity * Time.deltaTime;
    }
}