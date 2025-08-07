// Author: Larisa Xie
// Class: CS467 Summer 2025
// Date: 7/27/25
// Description: Interacting with gameobjects in the correct order will reveal
// a wall with a clue to next puzzle.

using TMPro;
using UnityEngine;
using UnityEngine.Audio;

public class CheckWatered : MonoBehaviour
{
    //public GameObject Wall;
    [SerializeField] private Animator MoveWall;
    public AudioSource sfxWater;
    public GameObject plant1; // 1
    public GameObject plant2;
    public GameObject plant3;
    public GameObject plant4;
    public GameObject WaterCan;
    public TextMeshProUGUI Message;
    public string code = "23142"; // assigned a number to each plant
    private string input = "";

    void Start()
    {
        sfxWater = GetComponent<AudioSource>();
    }

    public void PickWaterCan()
        // If Player interacts with watercan, change houseplants layer to Interactable.
    {
        WaterCan.SetActive(false);
        Message.text = "You picked up a Watering Can.";
        plant1.layer = LayerMask.NameToLayer("Interactable");
        plant2.layer = LayerMask.NameToLayer("Interactable");
        plant3.layer = LayerMask.NameToLayer("Interactable");
        plant4.layer = LayerMask.NameToLayer("Interactable");
    }

    public void WaterSFX()
    {
        Message.text = "You watered this plant.";
        sfxWater.Play();

    }

    public void Plant1()
    {
        if (input.Length < 5)
        {            
            input = input + "1";
            WaterSFX();
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
            WaterSFX();
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
            WaterSFX();
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
            WaterSFX();
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
            Message.text = "Good job. The vines are growing.";
            MoveWall.SetBool("Moved", true);
            Debug.Log("Correct");
        }
        else
        {
            Message.text = "Incorrect. Try again.";
            input = "";
            Debug.Log("Incorrect");
        }
    }
}
