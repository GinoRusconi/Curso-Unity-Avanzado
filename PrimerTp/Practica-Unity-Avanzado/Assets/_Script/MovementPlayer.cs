using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    private CharacterController characterController;
    private bool isGround;
    private Vector3 playerVelocity;
    public float playerSpeed = 2f;
    public float playerRotateSpeed = 2f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;

    void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        isGround = characterController.isGrounded;
        if (isGround && characterController.velocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("AD"), 0, Input.GetAxis("WS"));
        characterController.Move(Time.deltaTime * playerSpeed * move);

        

        Vector3 rotate = new Vector3(0, Input.GetAxis("Horizontal"), 0);
        transform.Rotate(Time.deltaTime * playerRotateSpeed * rotate);


        if (Input.GetButtonDown("Jump") && isGround)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        characterController.Move(playerVelocity * Time.deltaTime);
    }
}
