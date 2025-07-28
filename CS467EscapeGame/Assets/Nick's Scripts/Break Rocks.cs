// Some of the following code was generated from Unity as the default script and then was adapted to suit the program's needs. 
// Please see the attached README for a full list of sources for this code. Helpful sources will be mentioned here but are not meant to be exhaustive. 


using UnityEngine;

public class BreakRocks : MonoBehaviour
{
    public bool pickaxe_check;
    public string interact_check;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Script Started");
    }

    // Update is called once per frame

    /* This programming was developed and adapted from the sources at these two links:
    https://docs.unity3d.com/ScriptReference/KeyCode.html
    https://docs.unity3d.com/ScriptReference/Input.html
    Please see the README for a full list of sources.
    */
    void Update()
    {
        if (interact_check == "yes"){

            Debug.Log("yep");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Destroy(gameObject);
        }
    }
}
