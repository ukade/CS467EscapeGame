using UnityEngine;
using System.Collections;

//CS 467, Summer 2025
//Description: A script to enable quitting the game via "Quit" button from Start Menu, as well as hitting
//'esc' key on keyboard. Applies to both the game build and while within the Unity Editor

//Code referenced and adapted from:
//DA LAB. [DA-LAB]. (2022, August 6). Unity - Quit with Button Click or Keyboard Input YouTube. 
//https://www.youtube.com/watch?v=coEs4hKFoes Accessed July 20, 2025.

//Additional reference on how to quit while inside the Unity Editor
//Dąbrowski, Damian. (2024, February 20). Quit application on Escape button in Unity. Medium.
//https://damiandabrowski.medium.com/quit-application-on-escape-button-in-unity-bf02b8091b5f Accessed 7/21/2025.

//Quits the player when the user hits escape
public class Quit : MonoBehaviour
{

    //Below Update function checks if user clicks Esc key. If yes, quit the game
    void Update()
    {
		//GetKeyDown captures the key being pressed, not held
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Below code enables "quitting" while in Editor's Play Mode. 
			//Pre-processor directives to check if user is currently in the Unity Editor
			//if yes (isPlaying), then we turn the Editor App to "false" to quit
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
			//This is the usual quit function provided within Unity
            Application.Quit();
#endif
        }
    }
}