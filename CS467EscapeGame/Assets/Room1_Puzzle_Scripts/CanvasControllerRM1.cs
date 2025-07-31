// Author: Larisa Xie
// Class: CS467 Summer 2025
// Date: 7/23/25
// Description: Shows and hides canvas.

using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Player;
    private FirstPersonController Controller;

    private void Start()
    {
        Controller = Player.GetComponent<FirstPersonController>();
    }

    public void ShowCanvas()
    {
        if (Canvas != null)
        {
            Canvas.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None; // Reenable Cursor
            Controller.enabled = false;
        }
    }

    public void HideCanvas()
    {
        Canvas.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Controller.enabled = true;
    }
}

// How to Make a Working Keypad in Unity Using C# uploaded by Omogonix
// https://www.youtube.com/watch?v=1c5XNjChxQk&t=338s
// Accessed on 7/23/25