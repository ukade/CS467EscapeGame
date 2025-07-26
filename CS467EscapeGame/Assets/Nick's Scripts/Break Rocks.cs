// Some of the following code was generated from Unity as the default script and then was adapted to suit the program's needs. 
// Please see the attached README for a full list of sources for this code. Helpful sources will be mentioned here but are not meant to be exhaustive. 


using UnityEngine;

public class BreakRocks : MonoBehaviour
{
    public bool pickaxe_check;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Script Started");
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    /* Adapted from the scipt in the Unity Documentation to destroy an object. For sources that are helpful on this block of code see
     source #35 and the Microsoft reference sources. Please see README for full sources list.*/
    void OnMouseDown()
    {
        pickaxe_check = true;
        //If the check for having a pickaxe in your inventory comes out to be true, then break the rocks an have them dissapear.
        if (pickaxe_check == true)
        {
            Destroy(gameObject);
            Debug.Log("Its working.");
        }
    }
}
