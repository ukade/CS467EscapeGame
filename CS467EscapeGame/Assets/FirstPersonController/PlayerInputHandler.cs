// Author: Larisa Xie
// Class: CS467 Summer 2025
// Date: 7/6/25
// Description: Handles action inputs by Unity's New Input System. 

using UnityEngine;
using UnityEngine.InputSystem;

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

    private InputAction moveAction;
    private InputAction rotateAction;
    private InputAction jumpAction;

    public Vector2 MoveInput {  get; private set; }
    public Vector2 RotateInput { get; private set; }
    public bool JumpInput { get; private set; }

    private void Awake()
        // Awake scripts initialize before all other functions.
        // This function searches action inputs being performed by Player.
    {
        InputActionMap mapReference = playerControls.FindActionMap(actionMapName);

        moveAction = mapReference.FindAction(movement);
        rotateAction = mapReference.FindAction(rotation);
        jumpAction = mapReference.FindAction(jump);

        SubscribeActionValuesToInputEvents();

    }

    private void SubscribeActionValuesToInputEvents()
        // Action inputs performed by Player are referenced and then triggers the action in-game.
    {
        moveAction.performed += inputInfo => MoveInput = inputInfo.ReadValue<Vector2>(); // Allows Player to move
        moveAction.canceled += inputInfo => MoveInput = Vector2.zero;

        rotateAction.performed += inputInfo => RotateInput = inputInfo.ReadValue<Vector2>(); // Allows Player to rotate view
        rotateAction.canceled += inputInfo => RotateInput = Vector2.zero;

        jumpAction.performed += inputInfo => JumpInput = true; 
        jumpAction.canceled += inputInfo => JumpInput = false;
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