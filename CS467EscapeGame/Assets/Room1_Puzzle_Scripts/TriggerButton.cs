// Author: Larisa Xie
// Class: CS467 Summer 2025
// Date: 8/3/25
// Description: A button that triggers the opening/closing of
// the doors of the House on the Hill.

using UnityEngine;

public class TriggerButton : MonoBehaviour
{
    [SerializeField] private Animator HomeDoor;
    public GameObject ButtonMesh;
    int counter = 0;

    private void OnTriggerEnter(Collider other)
    {
        
        if (!HomeDoor.GetBool("Open"))
        {
            counter++;
            if(counter > 0)
            {
                HomeDoor.SetBool("Open", true); // Opens Door
            }           
            
        }
        Debug.Log("Player entered the trigger zone.");
        ButtonMesh.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {        
        if (HomeDoor.GetBool("Open"))
        {
            counter--;
            if (counter == 0) // Keeps door from closing due to multiple triggers
            {
                HomeDoor.SetBool("Open", false);
            }          
            
        }
        Debug.Log("Player left the trigger zone.");
        ButtonMesh.SetActive(true);

    }
}
