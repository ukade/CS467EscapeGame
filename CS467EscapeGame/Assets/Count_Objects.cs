// author: Brian Swanson
// accessed: 7/13/2025
// CS 467, Summer 2025
// Description: A script to enable picking up, dropping, and throwing solid objects
// Note: Any objects being picked up must have a Colider and RigidBody set up for this to work
// Also: ensure the player is set to scale 1, 1, 1 or the object it grabs will get its shape distorted
// Sources: https://www.geeksforgeeks.org/c-sharp/c-sharp-hashset-class/
//          https://docs.unity3d.com/ScriptReference/Object.GetInstanceID.html?from=MonoBehaviour


using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class Count_Objects : MonoBehaviour
{
    [SerializeField]
    int held = 0;
    [SerializeField]
    HashSet<int> balls_in_bin = new HashSet<int>();

    OnTriggerEnter box;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    // counts objects that enter the container once, ignores player
    {
        if (other.gameObject.name != "Player")
        {
            if (!balls_in_bin.Contains(other.gameObject.GetInstanceID()))
            {
                balls_in_bin.Add(other.gameObject.GetInstanceID());
                held++;
                Debug.Log($"{other.gameObject.GetInstanceID()} added to bin");

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
