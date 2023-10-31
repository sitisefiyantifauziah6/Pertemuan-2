using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f; // Movement speed
    public float gravity = 0f; // Gravity acceleration
    public float jumpHeight = 30f; // Jump height

    public Transform groundCheck;
    public float groundDistance = 0.4f; // Radius of the sphere used to check if the player is grounded
    public LayerMask groundMask; // Layer mask to determine what is considered ground

    Vector3 velocity; // Current velocity
    bool isGrounded; // Is the player grounded?

    // Update is called once per frame
    void Update()
    {
        // Check if the player is grounded by casting a sphere at the groundCheck position.
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; // Reset vertical velocity when grounded
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // Calculate the movement vector based on the player's input.
        Vector3 move = transform.right * x + transform.forward * z;

        // Move the character controller.
        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            // Apply an upward force to jump.
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        // Apply gravity to the vertical velocity.
        velocity.y += gravity * Time.deltaTime;

        // Move the character controller based on the final velocity.
        controller.Move(velocity * Time.deltaTime);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}