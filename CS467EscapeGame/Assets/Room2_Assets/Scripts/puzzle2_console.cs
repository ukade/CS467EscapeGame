// author: Brian Swanson
// accessed: 7/19/2025
// CS 467, Summer 2025
// Description: A script to activate the Trigger Collider on the Puzzle2 Console
// This also has functions to accept a buttonId and track the overall puzzle completion with the set


using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class puzzle2_console : MonoBehaviour
{
    public bool isAtConsole = false;
    private HashSet<int> buttonsPressed = new HashSet<int>();
    private int[] solution = { 2, 3, 4, 5, 7, 8, 10, 11, 15 };

    public GameObject sign3;
    [SerializeField] bool isComplete = false;

    public void receiveButtonPress(int buttonId)
    {
        // When a button press is received from tree_button, add it to the set
        buttonsPressed.Add(buttonId);
        CheckSolution();
    }

    public void removeButtonPress(int buttonId)
        // removes a button from buttonsPressed if the user turns the button off
    {
        buttonsPressed.Remove(buttonId);
        CheckSolution();
    }

    private void CheckSolution()
        // function to check if all elements of solution are in buttonsPressed
    {
        if (solution.All(buttonsPressed.Contains))
        {
            isComplete = true;
            sign3.SetActive(isComplete);


        }
    }


    private void OnTriggerEnter(Collider other)
    {
        // tracks the player's location within the trigger collider to enable button presses
        if (other.CompareTag("Player"))
        {
            isAtConsole = true;
        }
    }
}
