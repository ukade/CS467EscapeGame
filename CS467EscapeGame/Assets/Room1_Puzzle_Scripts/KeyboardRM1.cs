using Mono.Cecil.Cil;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static Unity.Collections.AllocatorManager;
using static UnityEngine.UI.Image;

public class KeyboardRM1 : MonoBehaviour
{
    [SerializeField] private string pwHere = "Insert Code Here";
    public TMP_InputField password;
    public string pw;
    public GameObject keya;
    public GameObject keyb;
    public GameObject keyc;
    public GameObject keyd;
    public GameObject keye;
    public GameObject keyf;
    public GameObject keyg;
    public GameObject keyh;
    public GameObject keyi;
    public GameObject keyj;
    public GameObject keyk;
    public GameObject keyl;
    public GameObject keym;
    public GameObject keyn;
    public GameObject keyo;
    public GameObject keyp;
    public GameObject keyq;
    public GameObject keyr;
    public GameObject keys;
    public GameObject keyt;
    public GameObject keyu;
    public GameObject keyv;
    public GameObject keyw;
    public GameObject keyx;
    public GameObject keyy;
    public GameObject keyz;
    public GameObject space;
    public GameObject back;
    public GameObject keyenter;
    public GameObject keyclear;

    public GameObject blockw;
    public GameObject blocka;
    public GameObject blockk;
    public GameObject blocke;
    public GameObject blocku;
    public GameObject blockp;
    public GameObject platform;

    public void KeyA()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + "A";
        }

    }
    public void KeyB()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + "B";
        }

    }
    public void KeyC()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + "C";
        }

    }
    public void KeyD()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + "D";
        }

    }
    public void KeyE()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + "E";
        }

    }
    public void KeyF()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + "F";
        }

    }
    public void KeyG()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + "G";
        }

    }
    public void KeyH()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + "H";
        }

    }
    public void KeyI()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + "I";
        }

    }
    public void KeyJ()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + "J";
        }

    }
    public void KeyK()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + "K";
        }

    }
    public void KeyL()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + "L";
        }

    }
    public void KeyM()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + "M";
        }

    }
    public void KeyN()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + "N";
        }

    }
    public void KeyO()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + "O";
        }

    }
    public void KeyP()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + "P";
        }

    }
    public void KeyQ()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + "Q";
        }

    }
    public void KeyR()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + "R";
        }

    }
    public void KeyS()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + "S";
        }

    }
    public void KeyT()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + "T";
        }

    }
    public void KeyU()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + "U";
        }

    }
    public void KeyV()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + "V";
        }

    }
    public void KeyW()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + "W";
        }

    }
    public void KeyX()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + "X";
        }

    }
    public void KeyY()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + "Y";
        }

    }
    public void KeyZ()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + "Z";
        }

    }

    public void SpaceKey()
    {
        if (password.text.Length < 10)
        {
            password.text = password.text + " ";
        }
    }

    public void BackKey()
    {
        if (password.text.Length < 10 && password.text != null)
        {
            password.text = password.text.Substring(0, password.text.Length - 1); // [1]

        }
    }
        
    public void EnterKey()
    {
        if (password.text == pwHere)
        {
            password.text = "Access Granted";
            blockw.GetComponent<MeshRenderer>().enabled = true;
            blocka.GetComponent<MeshRenderer>().enabled = true;
            blockk.GetComponent<MeshRenderer>().enabled = true;
            blocke.GetComponent<MeshRenderer>().enabled = true;
            blocku.GetComponent<MeshRenderer>().enabled = true;
            blockp.GetComponent<MeshRenderer>().enabled = true;
            platform.GetComponent<BoxCollider>().enabled = false;
            Debug.Log("Success");
        }
        else
        {
            ClearKey();
            Debug.Log("Access Denied");
        }
    }
    public void ClearKey()
    {
        password.text = null;
    }
}

// Knowledge learned from how to make a Keypad was used in creating this keyboard script. See KeypadRM1.cs
// This script was created on 7/28/25

// [1] https://stackoverflow.com/questions/65282443/why-does-my-backspace-return-a-new-text-instead-of-updating-the-current-text
// Author: Peter Duniho
// Accessed on 7/28/25

// How To Make A Keypad in Unity (EASY!) uploaded by It's Networking
// https://www.youtube.com/watch?v=sURDTT8UkfQ
// Accessed on 7/22/25

// How to Make a Working Keypad in Unity Using C# uploaded by Omogonix
// https://www.youtube.com/watch?v=1c5XNjChxQk&t=338s
// Accessed on 7/23/25

// How To Make Door Unlock With Keypad In Unity uploaded by M-Unity-Developer
// https://www.youtube.com/watch?v=TO0g5jyjpYU
// Accessed on 7/23/25
