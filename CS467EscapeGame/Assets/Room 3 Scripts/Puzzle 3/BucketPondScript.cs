/* Some of the code below is generated automatically when Unity creates a MonoBehavior script. It has been adapted to work for our teams project. 
Some sources are included below because they are particularly relevant but they are not meant to be an exhaustive list. 
The below code was built after learning from/adapted from code from several different sources. 
Please see the attached README for a full list of cited sources. 
*/

using UnityEngine;

public class BucketPondScript : MonoBehaviour
{
    /* Built after learning from/adapted from these relevant sources:
    https://docs.unity3d.com/Manual/class-GameObject.html
    https://docs.unity3d.com/ScriptReference/GameObject.html
    https://learn.microsoft.com/en-au/dotnet/csharp/language-reference/builtin-types/bool
    Please see the attached README for a full list of cited sources.
    */
    public GameObject pond;
    public GameObject bucketWater;
    bool filledWithWater;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* Adapted from/inspired the following sources and possibly others from the README:
    https://docs.unity3d.com/ScriptReference/Collider.OnTriggerEnter.html
    https://docs.unity3d.com/ScriptReference/GameObject.SetActive.html
    https://docs.unity3d.com/Manual/class-GameObject.html
    See README for a full list of sources.
    */
    void OnTriggerEnter(Collider objectCollider)
    {
        if (objectCollider.gameObject == pond)
        {
            bucketWater.SetActive(true);
            filledWithWater = true;
        }
    }
}
