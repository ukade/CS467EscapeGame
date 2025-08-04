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
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player entered the trigger zone.");
        ButtonMesh.SetActive(false);
        if (!HomeDoor.GetBool("Open"))
        {
            HomeDoor.SetBool("Open", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Player left the trigger zone.");
        ButtonMesh.SetActive(true);
        if (HomeDoor.GetBool("Open"))
        {
            HomeDoor.SetBool("Open", false);
        }
        
    }
}
