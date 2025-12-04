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
    InputAction moveAction;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveVector = moveAction.ReadValue<Vector2>();
        if (moveVector.x < 0)
        {
            //write to unity console
            Debug.Log("Left");
            rb.AddTorque(torqueAmount);
        }
        else if(moveVector.x > 0)       
            rb.AddTorque(-torqueAmount);

        //Add a jump when the player presses the up arrow or W key
        if (moveVector.y > 0)
        {
            Debug.Log("Jump");
            //limit jump to when player is on the ground and to a certain height
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

        }
    }
}
