using UnityEngine;

public class TimesUp : MonoBehaviour
{
    [SerializeField] GameObject timesUp;
    public void Pause()
    {
        //When Countdown reaches the end / 0? , calls this function to show pause
        timesUp.SetActive(true);
        Time.timeScale = 0;
    }

    public void Continue()
    {
        //When Continue? button is selected, game resumes
        timesUp.SetActive(false);
        Time.timeScale = 1;
    }
}
