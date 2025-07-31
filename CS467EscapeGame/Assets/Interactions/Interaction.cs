// Author: Larisa Xie
// Class: CS467 Summer 2025
// Date: 7/10/25
// Description: Uses Raycast to trigger Interactions when in range of GameObject.

using StarterAssets.Interactions;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interaction : MonoBehaviour
{
    [SerializeField] private LayerMask interactableLayer;

    private PlayerInput playerInput;
    private InteractableObject curInteractable;
    public Camera mainCamera;
    public GameObject interactText; // text that appears when you are within range of an interactable object.

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        InteractText();
    }

    private void OnEnable()
    {        
        if (playerInput != null)
        {
            playerInput.actions["Interact"].performed += OnInteract;
        }
    }

    private void OnDisable()
    {
        if (playerInput != null)
        {
            playerInput.actions["Interact"].performed -= OnInteract;
        }
    }

    private void OnInteract(InputAction.CallbackContext callbackContext) // InputAction.CallbackContext gets method defined in the developer environment in Interface
        // Uses Raycast to determine if interactableObject is within range
    {
        Ray ray = mainCamera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        RaycastHit hit;
        
        if (!Physics.Raycast(ray, out hit, 1f, interactableLayer))
        {
            Debug.Log("Not Interacted");
            return;
        }

        if (!hit.transform.TryGetComponent(out InteractableObject interactable))
        {
            return;
        }

        interactable.Interact();
        Debug.Log("Interacted");
    }

    private void InteractText() // Shows Interaction Text; Called from InteractableObject.cs
    {
        Ray ray = mainCamera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 1f, interactableLayer))
        {
            InteractableObject interactableObject = hit.collider.GetComponent<InteractableObject>();
            if (interactableObject != null && interactableObject != curInteractable)
            {
                curInteractable = interactableObject;
                interactText.SetActive(true);
                TextMeshProUGUI textComponent = interactText.GetComponent<TextMeshProUGUI>();
                if (textComponent != null)
                {
                    textComponent.text = curInteractable.GetInteractText();
                }                
            }
        }

        else
        {
            curInteractable = null;
            interactText.SetActive(false);
        }
    }
}

// Interactions with Unity Events - New Input System uploaded by ErenCode
// Accessed on 7/10/2025
// https://www.youtube.com/watch?v=ZNiEbRL85Vc&t=384s

// Interact with ANYTHING - Unity 2024 FPS Interaction System Tutorial
// Accessed on 7/8/2025
// https://www.youtube.com/watch?v=kGKFiIxhoB8&t=860s
