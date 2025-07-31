// Author: Larisa Xie
// Class: CS467 Summer 2025
// Date: 7/6/25
// Description: Handles movement in-game, referencing action inputs from PlayerInputHandler

using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    [Header("Movement Speeds")]
    [SerializeField] private float walkSpeed = 1.0f;

    [Header("Jump Parameters")]
    [SerializeField] private float jumpForce = 2.0f;
    [SerializeField] private float gravityMultiplier = 3.0f;

    [Header("Look Parameters")]
    [SerializeField] private float mouseSensitivity = 0.1f;
    [SerializeField] private float upDownLookRange = 80f;

    [Header("References")]
    [SerializeField] private CharacterController characterController;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private PlayerInputHandler playerInputHandler;

    private Vector3 currMovement;
    private float verticalRotate;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Hides Cursor
        Cursor.visible = false;
    }

    void Update()
    {
        HandleMove();
        HandleRotate();
    }

    private Vector3 CalculateWorldDirection()
    {
        Vector3 inputDirection = new Vector3(playerInputHandler.MoveInput.x, 0f, playerInputHandler.MoveInput.y);
        Vector3 worldDirection = transform.TransformDirection(inputDirection);
        return worldDirection.normalized;
    }

    private void HandleJump()
    {
        if (characterController.isGrounded)
        {
            currMovement.y = -0.5f;
            
            if (playerInputHandler.JumpInput)
            {
                currMovement.y = jumpForce;
                currMovement.x = walkSpeed / 2;
            }
        }
        else
        {
            currMovement.y += Physics.gravity.y * gravityMultiplier * Time.deltaTime;
        }
    }

    private void HandleMove()
    {
        Vector3 worldDirection = CalculateWorldDirection();
        currMovement.x = worldDirection.x * walkSpeed;
        currMovement.z = worldDirection.z * walkSpeed;

        HandleJump();

        characterController.Move(currMovement * Time.deltaTime);

    }

    private void HorizontalRotate(float rotateAmount)
    {
        transform.Rotate(0, rotateAmount, 0);
    }

    private void VerticalRotate(float rotateAmount)
    {
        verticalRotate = Mathf.Clamp(verticalRotate - rotateAmount, -upDownLookRange, upDownLookRange);
        mainCamera.transform.localRotation = Quaternion.Euler(verticalRotate, 0, 0);
    }

    private void HandleRotate()
    {
        float mouseXRotation = playerInputHandler.RotateInput.x * mouseSensitivity;
        float mouseYRotation = playerInputHandler.RotateInput.y * mouseSensitivity;

        HorizontalRotate(mouseXRotation);
        VerticalRotate(mouseYRotation);
    }
}

// How to Make a FIRST PERSON CONTROLLER in Unity uploaded by Brockosh
// Accessed 7/6/2025 
// https://www.youtube.com/watch?v=vBWcb_0HF1c