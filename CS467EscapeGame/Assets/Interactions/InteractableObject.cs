// Author: Larisa Xie
// Class: CS467 Summer 2025
// Date: 7/10/25
// Description: The fields of the interaction interface that can be viewed under Inspector.
// Interface field includes GetInteractText() and Interact()

using UnityEngine;
using UnityEngine.Events;

namespace StarterAssets.Interactions
{
    public class InteractableObject : MonoBehaviour, IInteractable // Attaches Interact() Interface 
    {
        [SerializeField] private UnityEvent onInteract;
        public string interactText = "Press E to Interact";

        UnityEvent IInteractable.onInteract
        {
            get => onInteract;
            set => onInteract = value;
        }

        public string GetInteractText()
        {
            return interactText;
        }
        
        public void Interact() => onInteract.Invoke();

    }
}

// Interactions with Unity Events - New Input System uploaded by ErenCode
//Accessed 7/10/2025
// https://www.youtube.com/watch?v=ZNiEbRL85Vc&t=384s
