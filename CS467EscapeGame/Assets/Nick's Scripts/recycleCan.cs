using System.Collections.Generic;
using UnityEngine;

public class garbageCan : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] int totalItems;
    [SerializeField] List<string> itemsInContainer = new List<string>();
    [SerializeField] string garbageType;
    void Start()
        // do we need this if we're tracking everything in onTriggerEnter?
    {
        // so you could do your plan of finding all of the objects here
        // or you could create a [SerializedField] list of letters that you attach in Unity itself before the game launches

    }

    // Update is called once per frame
    void Update()
        // do we need update if we are tracking everything in OnTriggerEnter?
    {
        // if itemsInContainer.size() == totalItems
            // we're done?
    }

    private void OnTriggerEnter(Collider other)
        // goal: validate the item thrown in the bin belongs there
        // if yes: spawn a letter
        // if no: spit the item out
    {
        // if the tag on the garbage is the same as the garbageType:
            // increment held
            // spawn a letter based on a garbageId variable on each piece of trash?
            // destroy the object
        // else, the garbage doesn't belong in this can
            // throw it out with rb.AddForce() ?
    }
}
