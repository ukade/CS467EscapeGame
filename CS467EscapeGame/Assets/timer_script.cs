// Author: Brian Swanson
// CS 467 Summer 2025
// timer_script
// UI Script to track the time it takes the player to complete each room.
// TODO: Adapt this to provide the time value to another script that tracks time taken to complete each room.
// TODO: Set up a UI popup that says something like "You've passed the goal time, do you want to continue or start over?" with buttons for both options.
// TODO: Insert times for each room completion onto the final screen.

/*
 * Unity Technologies. (2025). Time (Scripting API). In Unity Scripting API. Retrieved July 29, 2025, from https://docs.unity3d.com/ScriptReference/Time.html
 * Rehope Games. (2023, May 2). Make a TIMER & COUNTDOWN in 5 mins | Unity tutorial for beginners [Video]. YouTube. https://www.youtube.com/watch?v=POq1i8FyRyQ
 */

using UnityEngine;
using TMPro;

public class timer_script : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float goalTime = 900f; // default value 15 min in seconds, can be reset based on room
    public bool timesUp = false;
    public bool pauseMarker = false;

    public GameObject pauseScreen;

    private float currentTime = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // with each frame the currentTime object updates as seconds pass
        // this also converts the seconds to minutes and then formats them to display
        if (!timesUp)
        {
            currentTime += Time.deltaTime;

            if (currentTime >= goalTime - 30f)
            {
                pauseMarker = true;
                timesUp = true;
                //Call Pause Menu scene / canvas
                pauseScreen.SetActive(true);
                Time.timeScale = 0f;
            }

            UpdateTimerDisplay();

        }

        void UpdateTimerDisplay()
        {
            int minutes = Mathf.FloorToInt(currentTime / 60f); // convert to minutes
            int seconds = Mathf.FloorToInt(currentTime % 60f); // convert to seconds

            string timeFormatted = string.Format("{0:00}:{1:00}", minutes, seconds);
            string goalFormatted = string.Format("{0:00}:{1:00}", Mathf.FloorToInt(goalTime / 60f), Mathf.FloorToInt(goalTime % 60f));

            timerText.text = $"{timeFormatted} / {goalFormatted}";
        }
    }
}
