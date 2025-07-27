// author: Brian Swanson
// accessed: 7/19/2025
// CS 467, Summer 2025
// Description: A script to activate the Trigger Collider on the Puzzle2 Console


using UnityEngine;

public class puzzle2_console : MonoBehaviour
{
    public bool isAtConsole = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isAtConsole = true;
        }
    }
}
