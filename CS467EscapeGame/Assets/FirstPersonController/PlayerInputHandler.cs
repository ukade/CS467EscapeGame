using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;



public class PlayerInputHandler : MonoBehaviour
{
    [Header("Input Action Asset")]
    [SerializeField] private InputActionAsset playerControls;

    [Header("Action Map Name Reference")]
    [SerializeField] private string actionMapName = "Player";

    [Header("Action Name References")]
    [SerializeField] private string movement = "Movement";
    [SerializeField] private string rotation = "Rotation";
    [SerializeField] private string jump = "Jump";

    private InputAction movementAction;
    private InputAction rotationAction;
    private InputAction jumpAction;

    public Vector2 MovementInput {  get; private set; }
    public Vector2 RotationInput { get; private set; }
    public bool JumpTriggered { get; private set; }

    private void Awake()

    {

        InputActionMap mapReference = playerControls.FindActionMap(actionMapName);

        movementAction = mapReference.FindAction(movement);
        rotationAction = mapReference.FindAction(rotation);
        jumpAction = mapReference.FindAction(jump);

        SubscribeActionValuesToInputEvents();

    }

    private void SubscribeActionValuesToInputEvents()
    {
        movementAction.performed += inputInfo => MovementInput = inputInfo.ReadValue<Vector2>();
        movementAction.canceled += inputInfo => MovementInput = Vector2.zero;

        rotationAction.performed += inputInfo => RotationInput = inputInfo.ReadValue<Vector2>();
        rotationAction.canceled += inputInfo => RotationInput = Vector2.zero;

        jumpAction.performed += inputInfo => JumpTriggered = true;
        jumpAction.canceled += inputInfo => JumpTriggered = false;
    }

    private void OnEnable()
    {
        if (playerControls != null)
        {
            playerControls.FindActionMap(actionMapName).Enable();
        }
    }
    private void OnDisable()
    {
        if (playerControls != null)
        {
            playerControls.FindActionMap(actionMapName).Disable();
        }
    }
}

// How to Make a FIRST PERSON CONTROLLER in Unity uploaded by Brockosh
// Accessed 7/6/2025
// https://www.youtube.com/watch?v=vBWcb_0HF1c