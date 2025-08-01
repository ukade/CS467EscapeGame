// Portions of the script below were generated by default when inserting a MonoBehavior Script in Unity. 

/* The rest of the script was built/adapted by myself from the sources in the attached README file.
Primarily the Unity and Microsoft C# documentation was used. Some helpful sources will be mentioned
in the comments by certain portions of code, but these are not meant to be exhaustive. See the attached 
README for a full list of sources cited. */


using UnityEngine;

public class PermPickupScript : MonoBehaviour
{

    public GameObject activatingObject;
    public bool hasPickedUp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    
    /* The below code was developed using the following links specifically: 
    https://docs.unity3d.com/ScriptReference/GameObject.SetActive.html
    https://docs.unity3d.com/ScriptReference/Input.html
    https://docs.unity3d.com/ScriptReference/Component-gameObject.html
    https://docs.unity3d.com/ScriptReference/GameObject.html
    https://docs.unity3d.com/ScriptReference/Object.Destroy.html

    Please see the attached README for a full list of citations.
    */
    
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            hasPickedUp = true;
            gameObject.SetActive(false);
            activatingObject.SetActive(true);

        }
    }
}
