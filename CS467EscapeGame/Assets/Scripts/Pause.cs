using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject TimesUp;

    void Start()
    {
        
    }

    void Update()
    {
        if (TimesUp.activeInHierarchy)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }


    public void Continue()
    {
        Debug.Log("In Continue");
        TimesUp.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Debug.Log("In Quit");
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        //This is the usual quit function provided within Unity
        Application.Quit();
#endif
    }
}
