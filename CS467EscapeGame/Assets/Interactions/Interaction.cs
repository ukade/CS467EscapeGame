using StarterAssets.Interactions;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interaction : MonoBehaviour
{
    [SerializeField] private LayerMask interactableLayer;
    private PlayerInput playerInput;
    public Camera mainCamera;
    public GameObject interactText;
    private InteractableObject curInteractable;

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


    private void OnInteract(InputAction.CallbackContext callbackContext) // Player Interaction
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
    private void InteractText() // Shows Interaction Text
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

//Interact with ANYTHING - Unity 2024 FPS Interaction System Tutorial
// Accessed on 7/8/2025
//https://www.youtube.com/watch?v=kGKFiIxhoB8&t=860s
