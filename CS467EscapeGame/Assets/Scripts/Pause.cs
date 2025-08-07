//Katrine Chow
//CS 467 Summer 2025
//Description: This controls the behavior of a pause screen, which pops up when goalTime elapses,
//and notifies player that time is up. The screen remains invisible until timer triggers it

using UnityEngine;
//using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject TimesUp;

    void Start()
    {
        
    }

    void Update()
    {
        //Sourced from Brian Swanson's OpenDoor.cs script to make cursor visible when TimesUp
        //GameObject is active
        if (TimesUp.activeInHierarchy)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }


    public void Continue()
    {
        //Referenced and adapted from the following YouTube tutorial:
        //BMo [BMoDev]. (2020, May 18). 6 Minute PAUSE MENU Unity Tutorial. https://www.youtube.com/watch?v=9dYDBomQpBQ
        //YouTube. Accessed 8/2/2025.
        TimesUp.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Quit()
    {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        //This is the usual quit function provided within Unity
        Application.Quit();
#endif
    }
}