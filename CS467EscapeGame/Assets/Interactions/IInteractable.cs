// Author: Larisa Xie
// Class: CS467 Summer 2025
// Date: 7/10/25
// Description: Creates an interface in Unity Development Environment
// under Inspector window that allows the developer to define what the
// Interact() function does.

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
// Accessed 7/10/2025
// https://www.youtube.com/watch?v=ZNiEbRL85Vc&t=384s
