using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    private CharacterController controller;
    private Rigidbody rb;
    private float directionY;
    
    float moveSpeed = 6.5f;
    float gravity = 9.81f;

    void Start() 
    {
        animator = gameObject.GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }

    void Update() 
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");


        animator.SetFloat("SpeedX", x);
        animator.SetFloat("SpeedZ", z);

        Vector3 direction = transform.right * x + transform.forward * z;
        direction = Vector3.ClampMagnitude(direction, 1f);

        directionY -= gravity * Time.deltaTime;

        direction.y = directionY;

        controller.Move(direction * moveSpeed * Time.deltaTime);
    }
}
