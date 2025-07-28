using UnityEngine;
using UnityEngine.Windows;

public class CheckWatered : MonoBehaviour
{
    public GameObject Wall;
    public GameObject plant1;
    public GameObject plant2;
    public GameObject plant3;
    public GameObject plant4;
    public string code = "23142"; // plant2, plant3, plant1, plant4, plant2
    private string input = "";

    public void Plant1()
    {
        if (input.Length < 5)
        {
            input = input + "1";
            Debug.Log(input);

        }
        if (input.Length > 4)
        {
            CheckCode();
        }

    }

    public void Plant2()
    {
        if (input.Length < 5)
        {
            input = input + "2";
            Debug.Log(input);
        }
        if (input.Length > 4)
        {
            CheckCode();
        }
    }
    public void Plant3()
    {
        if (input.Length < 5)
        {
            input = input + "3";
            Debug.Log(input);
        }
        if (input.Length > 4)
        {
            CheckCode();
        }
    }
    public void Plant4()
    {
        if (input.Length < 5)
        {
            input = input + "4";
            Debug.Log(input);
        }
        if (input.Length > 4)
        {
            CheckCode();
        }
    }

    public void CheckCode()
    {
        if (input == code)
        {
            Wall.SetActive(false);
            Debug.Log("Correct");
        }
        else
        {
            input = "";
            Debug.Log("Incorrect");
        }
    }
}
