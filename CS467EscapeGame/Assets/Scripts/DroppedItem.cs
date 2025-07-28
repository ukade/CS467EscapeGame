using System.Collections;
using UnityEngine;

//CS 467,  Summer 2025
//Description: Script for testing - defines item dropping and pickup, a portion for inventory system
//in 3D space

//Code referenced and adapted from:
//RumpledCode. [RumpledCode]. (2025, February 24) . Unity Tutorial - Simple Inventory System YouTube.
//https://www.youtube.com/watch?v=y5NiylHo7rw Accessed 7/22/2025.

[RequireComponent(typeof(Collider))]
public class DroppedItem : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField]
    bool autoStart;

    [SerializeField]
    float enabledPickupDelay = 3.0f;

    [Header("State")]
    public Item item;
    public bool pickedUp = false;

    void Start()
    {
        if (autoStart && item != null)
        {
            Initialize(item);
        }
    }

    public void Initialize(Item item)
    {
        this.item = item;
        var droppedItem = Instantiate(item.prefab, transform);
        droppedItem.transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.identity);
        StartCoroutine(EnablePickup(enabledPickupDelay));
    }

    IEnumerator EnablePickup(float dealy)
    {
        yield return new WaitForSeconds(dealy);
        GetComponent<Collider>().enabled = true;
    }
}
