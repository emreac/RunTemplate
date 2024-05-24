using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private Joystick joystick;
    [Space(10)]
    [SerializeField] private float forwardSpeed;
    [SerializeField] private float leftRightSpeed;
    [SerializeField] private Vector2 minMaxX;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        //clamp x pos
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,minMaxX.x,minMaxX.y),transform.position.y,transform.position.z);
        rb.velocity = new Vector3(joystick.Horizontal * leftRightSpeed * Time.deltaTime, rb.velocity.y, forwardSpeed * Time.deltaTime);
    }
}
