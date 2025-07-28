using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void LoadNext()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

// Load a scene in Unity from a button in 60 seconds uploaded by RigorMortisTortoise
// Accessed on 7/22/2025
// https://youtube.com/shorts/qCKmtIKmRyQ?si=_y4UfH46gRyill4k
