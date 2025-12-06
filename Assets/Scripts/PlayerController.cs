using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float jumpForce = 0.1f;
    [SerializeField] float maxJumpHeight = 2f;
    [SerializeField] float baseSpeed = 15f;
    [SerializeField] float boostSpeed = 20f;

    Vector2 moveVector;
    InputAction moveAction;
    Rigidbody2D rb;
    SurfaceEffector2D surfaceEffector2D;
    // Start is called before the first frame update
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        rb = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveVector = moveAction.ReadValue<Vector2>();
        RotatePlyer();
        BoostPlayer();
    }

    void RotatePlyer()
    {


        if (moveVector.x < 0)
        {
            //write to unity console
            //Debug.Log("Left");
            rb.AddTorque(torqueAmount);
        }
        else if (moveVector.x > 0)
            rb.AddTorque(-torqueAmount);


    }

    void BoostPlayer()
    {
        if (moveVector.y > 0)
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }
}
