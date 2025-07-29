// Some of the following code was generated from Unity as the default script and then was adapted to suit the program's needs. 
// Please see the attached README for a full list of sources for this code. Helpful sources will be mentioned here but are not meant to be exhaustive. 


using UnityEngine;

public class BreakRocks : MonoBehaviour
{
    public bool pickaxe_check;
    public bool has_broken;
    public GameObject camper;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    /* Used the following sources in developing the folowing code 
    https://docs.unity3d.com/ScriptReference/Component.GetComponent.html
    https://docs.unity3d.com/Manual/class-GameObject.html#AccessingOtherGameObjects
    https://docs.unity3d.com/Manual/class-GameObject.html
    This is not an exhaustive list. Please see the attached README for a full list of sources. 
    */

    void Start()
    {
        Debug.Log("Script Started");
        camper = GameObject.Find("Player Flags");
    }

    // Update is called once per frame

    /* This programming was developed and adapted from the sources at these two links:
    https://docs.unity3d.com/ScriptReference/KeyCode.html
    https://docs.unity3d.com/ScriptReference/Input.html
    https://docs.unity3d.com/Manual/class-GameObject.html
    https://docs.unity3d.com/ScriptReference/Component.GetComponent.html
    https://docs.unity3d.com/ScriptReference/GameObject.SetActive.html
    It appears to me the only parameter that works for GetComponent is the name of the component with no spaces. 
    I see an example of this in the last source above but did not see where it was mentioned in any other sources. 
    Please see the README for a full list of sources.
    */
    void Update()
    {
        pickaxe_check = camper.GetComponent<PlayerFlags>().has_pickaxe;
        if (pickaxe_check == true){

            Debug.Log("yep");
        
            if (Input.GetKeyDown(KeyCode.E))
            {
                has_broken = true;
                gameObject.SetActive(false);
   
            }
        }
    }
}
