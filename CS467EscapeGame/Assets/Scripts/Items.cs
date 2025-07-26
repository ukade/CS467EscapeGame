using UnityEngine;

//Code referenced the following YouTube Tutorial:
//RumpledCode. [RumpledCode]. (2025, February 24). Unity Tutorial - Simple Inventory System. YouTube. 
//https://www.youtube.com/watch?v=y5NiylHo7rw Accessed 7/24/2025

//This adds a function to right-click menu to quickly create an item based on this class
[CreateAssetMenu(fileName = "Item", menuName = "Custom Create/Item", order = 1)]
public class Item
{
    public string id;
    public string description;
    public Sprite icon;
    public GameObject prefab;
}
