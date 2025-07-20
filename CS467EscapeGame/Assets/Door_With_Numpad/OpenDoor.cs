// author: Brian Swanson
// accessed: 7/19/2025
// CS 467, Summer 2025
// Description: A script that creates a door locked by a numpad with a 3-digit code
// Source: https://www.youtube.com/watch?v=dVUIg8A71RE

using UnityEngine;
using TMPro;

public class OpenDoor : MonoBehaviour
{


    private Animator anim;

    private bool isAtDoor = false;

    [SerializeField]
    private TextMeshProUGUI codeText;

    string codeTextValue = "";
    public string safeCode;
    public GameObject CodePanel;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    // includes functionality to activate the numpad if the player is next to the door and presses F
    // will unhide the keypad and cursor for the player to enter 3 digits
    // if the wrong 3 digits are added, a 4th digit will clear the code to start over
    {

        if (CodePanel.activeInHierarchy)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        } else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        codeText.text = codeTextValue;

        if (codeTextValue == safeCode)
        {
            anim.SetTrigger("OpenDoor");
            CodePanel.SetActive(false);
        }

        if(codeTextValue.Length >= 4)
        {
            codeTextValue = "";
        }

        if (Input.GetKeyDown(KeyCode.F) && isAtDoor == true)
        {
            CodePanel.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    // will set isAtDoor to true if the player is in front of the door (in the trigger collider)
    {
        Debug.Log("Trigger entered by: " + other.gameObject.name);
        if (other.CompareTag("Player"))
        {
            isAtDoor = true;
        }
    }

    private void OnTriggerExit(Collider other)
    // will set isAtDoor to false if the player moves away from the door
    {
        isAtDoor = false;
        CodePanel.SetActive(false);
    }

    public void AddDigit(string digit)
    // accepts a keypad press from the keypad
    {
        codeTextValue += digit;
    }
}
