// Author: Larisa Xie
// Class: CS467 Summer 2025
// Date: 7/27/25
// Description: A keypad. Enter the correct code and it will open a door.

using TMPro;
using UnityEngine;

public class KeypadRM1 : MonoBehaviour
{
    [SerializeField] private string CodeHere = "Insert Code Here";
    [SerializeField] private Animator SlideDoor;
    public TMP_InputField code;
    public GameObject key1;
    public GameObject key2;
    public GameObject key3;
    public GameObject key4;
    public GameObject key5;
    public GameObject key6;
    public GameObject key7;
    public GameObject key8;
    public GameObject key9;
    public GameObject key0;
    public GameObject keyenter;
    public GameObject keyclear;

    public void Key1()
    {
        if (code.text.Length < 5)
        {
            code.text = code.text + "1";
        }
    }

    public void Key2()
    {

        if (code.text.Length < 5)
        {
            code.text = code.text + "2";
        }
    }

    public void Key3()
    {
        if (code.text.Length < 5)
        {
            code.text = code.text + "3";
        }
    }

    public void Key4()
    {
        if (code.text.Length < 5)
        {
            code.text = code.text + "4";
        }
    }

    public void Key5()
    {
        if (code.text.Length < 5)
        {
            code.text = code.text + "5";
        }
    }

    public void Key6()
    {
        if (code.text.Length < 5)
        {
            code.text = code.text + "6";
        }
    }

    public void Key7()
    {
        if (code.text.Length < 5)
        {
            code.text = code.text + "7";
        }
    }

    public void Key8()
    {
        if (code.text.Length < 5)
        {
            code.text = code.text + "8";
        }
    }

    public void Key9()
    {
        if (code.text.Length < 5)
        {
            code.text = code.text + "9";
        }
    }

    public void Key0()
    {
        if (code.text.Length < 5)
        {
            code.text = code.text + "0";
        }
    }

    public void EnterKey()
    {
        if (code.text == CodeHere)
        {
            code.text = "Valid";
            SlideDoor.SetBool("Open", true);
            Debug.Log("Success");
        }
        else
        {
            ClearKey();
            Debug.Log("Failed");
        }
    }
    public void ClearKey()
    {
        code.text = null;
    }
}

// How To Make A Keypad in Unity (EASY!) uploaded by It's Networking
// https://www.youtube.com/watch?v=sURDTT8UkfQ
// Accessed on 7/22/25

// How to Make a Working Keypad in Unity Using C# uploaded by Omogonix
// https://www.youtube.com/watch?v=1c5XNjChxQk&t=338s
// Accessed on 7/23/25

// How To Make Door Unlock With Keypad In Unity uploaded by M-Unity-Developer
// https://www.youtube.com/watch?v=TO0g5jyjpYU
// Accessed on 7/23/25
