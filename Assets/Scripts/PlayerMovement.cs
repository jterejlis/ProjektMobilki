using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TouchControlsKit;


public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    private float horizontal;
    private float vertical;
    public float movementSpeed;

    public TCKJoystick Joystick;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Joystick.axisX.value;
        vertical = Joystick.axisY.value;
    }

    void FixedUpdate()
    {
        body.linearVelocity = new Vector2(horizontal * movementSpeed, vertical * movementSpeed);
    }
}
