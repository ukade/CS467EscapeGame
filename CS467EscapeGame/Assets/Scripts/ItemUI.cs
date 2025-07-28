using System;
using UnityEngine;
using UnityEngine.UI;

//CS 467,  Summer 2025
//Description: Script for testing: defines an item's UI image in the inventory, a portion for inventory system
//in 3D space

//Code referenced and adapted from:
//RumpledCode. [RumpledCode]. (2025, February 24) . Unity Tutorial - Simple Inventory System YouTube.
//https://www.youtube.com/watch?v=y5NiylHo7rw Accessed 7/22/2025.

[RequireComponent(typeof(Button))]
public class ItemUI : MonoBehaviour
{
    [Header("References")]
    [SerializeField]
    Image image;
    [SerializeField]
    Button button;

    public void Initialize(string inventoryId, Item item, Action<string> removeItemAction)
    {
        image.sprite = item.icon;
        transform.localScale = Vector3.one;
        button.onClick.AddListener(() => removeItemAction.Invoke(inventoryId));
    }

    void OnDestroy()
    {
        button.onClick.RemoveAllListeners();
    }
}
