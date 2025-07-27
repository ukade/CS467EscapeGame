// Author: Brian Swanson
// CS 467 Summer 2025
// Tree_Button Script
// A script that applies necessary componenets to prefabs in Room2 to revert potential Unity corruption.

/*
 * Unity Technologies. (n.d.). Rigidbody. Unity Manual. https://docs.unity3d.com/ScriptReference/Rigidbody.html

 * Unity Technologies. (n.d.). Object.Destroy. Unity Manual (Version 6000.1). https://docs.unity3d.com/6000.1/Documentation/ScriptReference/Object.Destroy.html

 * Unity Technologies. (n.d.). GameObject.AddComponent. Unity Manual (Version 6000.1). https://docs.unity3d.com/6000.1/Documentation/ScriptReference/GameObject.AddComponent.html
 */

using UnityEngine;

public class food_refresh : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created



    void Start()
    {
        GameObject[] boxGameObjects = GameObject.FindGameObjectsWithTag("box_food");
        GameObject[] capsuleGameObjects = GameObject.FindGameObjectsWithTag("capsule_food");

        Debug.Log("found: {box_food}");
        Debug.Log("found: {capsule_food}");


        foreach (GameObject obj in boxGameObjects)
        {
            // add rigidbody
            obj.AddComponent<Rigidbody>();

            // add box collider
            obj.AddComponent<BoxCollider>();

            // add pickup script
            obj.AddComponent<Pickup>();

            // remove mesh collider
            MeshCollider meshCollider = obj.GetComponent<MeshCollider>();
            Destroy(meshCollider);

            Debug.Log("applied box food components");
        }

        foreach (GameObject obj in capsuleGameObjects)
        {
            // add rigidbody
            obj.AddComponent<Rigidbody>();

            // add capsule collider
            obj.AddComponent<CapsuleCollider>();

            // add pickup script
            obj.AddComponent<Pickup>();

            // remove mesh collider
            MeshCollider meshCollider = obj.GetComponent<MeshCollider>();
            Destroy(meshCollider);

            Debug.Log("applied capsule food components");
        }
    }
}
