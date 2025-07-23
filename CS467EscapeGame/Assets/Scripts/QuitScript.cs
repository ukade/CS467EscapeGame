using UnityEngine;
using System.Collections;

// Quits the player when the user hits escape

public class Quit : MonoBehaviour
{
/*   public void QuitGame()
{
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Below code enables "quitting" while in Editor's Play Mode. Though it doesn't seem to work hmm...
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
}
*/
    //Below Update function checks if user clicks Esc key. If yes, quit the game
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Below code enables "quitting" while in Editor's Play Mode. Though it doesn't seem to work hmm...
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
            //Application.Quit();
        }
    }
}