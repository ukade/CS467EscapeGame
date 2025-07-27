using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

//CS 467,  Summer 2025
//Description: Script for testing: defines the UI component of adding/removing items, a portion for inventory system
//in 3D space

//Code referenced and adapted from:
//RumpledCode. [RumpledCode]. (2025, February 24) . Unity Tutorial - Simple Inventory System YouTube.
//https://www.youtube.com/watch?v=y5NiylHo7rw Accessed 7/22/2025.

public class InventoryUI : MonoBehaviour
{
    [Header("Prefabs")]
    [SerializeField]
    GameObject uiItemPrefab;

    [Header("References")]
    [SerializeField]
    Inventory inventory;
    [SerializeField]
    Transform uiInventoryParent;

    [Header("State")]
    [Header("SerializeField")]
    SerializedDictionary<string, GameObject> inventoryUI = new();

    public void AddUIItem(string inventoryId, Item item)
    {
        var itemUI = Instantiate(uiItemPrefab).GetComponent<ItemUI>();
        itemUI.transform.SetParent(uiInventoryParent);
        inventoryUI.Add(inventoryId, itemUI.gameObject);
        itemUI.Initialize(inventoryId, item, inventory.DropItem);
    }

    public void RemoveUIItem(string inventoryId)
    {
        var itemUI = inventoryUI.GetValueOrDefault(inventoryId);
        inventoryUI.Remove(inventoryId);
        Destroy(itemUI);
    }
}