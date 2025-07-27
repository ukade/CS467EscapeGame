// Author: Brian Swanson
// CS 467 Summer 2025
// Tree_Button Script
// A button that interacts with will set an "on" value to true, which activates a light in the button.
// Player will interact with this in Room 2 Puzzle 2 with the goal of pressing all of the buttons that correspond with trees

/*
 * Unity Technologies. (n.d.). Mouse events. Unity Documentation. https://docs.unity3d.com/Manual/UIE-Mouse-Events.html

 * Unity Technologies. (n.d.). MouseEnterEvent class. Unity Scripting API. https://docs.unity3d.com/ScriptReference/UIElements.MouseEnterEvent.html

 * Unity Technologies. (n.d.). MonoBehaviour.OnMouseOver. Unity Scripting API. https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnMouseOver.html

 * Unity Technologies. (n.d.). Light component. Unity Scripting API. https://docs.unity3d.com/6000.1/Documentation/ScriptReference/Light.html

 *  Technologies. (n.d.). Light component settings (URP). Unity Documentation. https://docs.unity3d.com/6000.1/Documentation/Manual/urp/light-component.html#General
 */

using UnityEngine;


public class tree_button : MonoBehaviour
{

    [SerializeField]
    bool isPressed = false;
    [SerializeField]
    int buttonId;

    private bool isAtButton = false;
    private bool mouseOnButton = false;
    private Light light;

    private void Start()
    {
        light = GetComponent<Light>();
    }

    private void OnTriggerEnter(Collider other)
    // triggered by a trigger collider at the button console
    // will give player ability to press the button
    {
        if (other.CompareTag("Player"))
        {
            isAtButton = true;
        }
    }

    private void OnMouseEnter()
    // will set mouseOnButton to true if the player is in the trigger collider and has the mouse over the button
    {
        if (isAtButton)
        {
            mouseOnButton = true;
        }
    }

    private void OnMouseExit()
    {
        mouseOnButton = false;
    }

    private void Update()
    // checks if the button is pressed, if so it lights up
    // attempts to detect the player pressed F while moused over the button
    // if so, will toggle light on if it is off, or toggle light off if on
    {

        if (Input.GetKeyDown(KeyCode.F) && mouseOnButton)
        {
            isPressed = !isPressed;
        }

        light.enabled = isPressed;
    }
}
