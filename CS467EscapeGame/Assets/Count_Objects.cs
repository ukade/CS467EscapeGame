// author: Brian Swanson
// accessed: 7/13/2025
// CS 467, Summer 2025
// Description: A script to enable picking up, dropping, and throwing solid objects
// Note: Any objects being picked up must have a Colider and RigidBody set up for this to work
// Also: ensure the player is set to scale 1, 1, 1 or the object it grabs will get its shape distorted
/*
 * Sources:
 * GeeksforGeeks. 2025, July 11. C# HashSet (with examples). In GeeksforGeeks. Retrieved from https://www.geeksforgeeks.org/c-sharp/hashset-in-c-sharp-with-examples/
 * 
 * Unity Technologies. n.d. Object.GetInstanceID. In Unity Scripting API. Retrieved from https://ocs.unity3d.com/ScriptReference/Object.GetInstanceID.html
 */


using System.Collections.Generic;
using UnityEngine;

public class Count_Objects : MonoBehaviour
{
    [SerializeField]
    int held = 0;
    [SerializeField]
    HashSet<int> balls_in_bin = new HashSet<int>();
    [SerializeField]
    bool isComplete = false;

    public GameObject Stairs;
    public GameObject sign2;

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

    private void Update()
    {
        if (balls_in_bin.Count == 8)
        {
            isComplete = true;
            Stairs.SetActive(isComplete);
            sign2.SetActive(isComplete);
        }
    }
}