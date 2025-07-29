using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject Canvas;

    public void ShowCanvas()
    {
        if (Canvas != null)
        {
            Canvas.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void HideCanvas()
    {
        Canvas.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}

// How to Make a Working Keypad in Unity Using C# uploaded by Omogonix
// https://www.youtube.com/watch?v=1c5XNjChxQk&t=338s
// Accessed on 7/23/25