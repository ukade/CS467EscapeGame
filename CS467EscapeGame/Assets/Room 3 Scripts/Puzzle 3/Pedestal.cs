/* Some of the code that is below was generated automatically by Unity when you make a script. It was modified to meet our groups objective of making an escape room. 
Some sources are listed here for convenience because they relate to a certain code section. Please see the README for a full list of sources*/



using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    /* Relevant Sources: 
    https://docs.unity3d.com/Manual/class-GameObject.html
    https://docs.unity3d.com/ScriptReference/GameObject.html
    https://docs.unity3d.com/ScriptReference/Component.GetComponent.html
    https://docs.unity3d.com/ScriptReference/Component.html
    https://docs.unity3d.com/ScriptReference/MonoBehaviour.html
    See README for full list of sources.
    */

    public GameObject pedestalItem;
    public GameObject correctLight;
    public GameObject incorrectLight;
    public GameObject caveRock;
    public OpenCave caveScript;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* Relevant Sources:
        https://docs.unity3d.com/Manual/class-GameObject.html
        https://docs.unity3d.com/ScriptReference/Component.GetComponent.html
        See README for full list of sources.
        */
        caveRock = GameObject.Find("CaveRock")
        caveScript = caveRock.GetComponent<OpenCave>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* Relevant Sources: 
        https://docs.unity3d.com/ScriptReference/Collider.OnTriggerEnter.html
    */

    void OnTriggerEnter(Collider objectCollider)
    {
        if (objectCollider == pedestalItem)
        {


        }
    }




}
