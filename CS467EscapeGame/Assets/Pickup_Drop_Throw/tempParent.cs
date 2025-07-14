// author: Brian Swanson
// adapted from: https://www.youtube.com/watch?v=fApXEL0xsx4
// accessed: 7/13/2025
// CS 467, Summer 2025
// Description: A script to enable picking up, dropping, and throwing solid objects
// Note: Any objects being picked up must have a Colider and RigidBody set up for this to work

using UnityEngine;

public class TempParent : MonoBehaviour
{
    public static TempParent Instance {  get; private set; }

    private void Awake()
        // this ensures there is one tempParent object present in the game
        // meaning we do not have to attach this script to every object in the game
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }


}