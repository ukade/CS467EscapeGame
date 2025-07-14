using UnityEngine.Events;


namespace StarterAssets.Interactions

{
    public interface IInteractable
    {
        public UnityEvent onInteract { get; protected set; }
        public void Interact();
    }
}

// Interactions with Unity Events - New Input System uploaded by ErenCode
//Accessed 7/10/2025
// https://www.youtube.com/watch?v=ZNiEbRL85Vc&t=384s
