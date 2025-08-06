//Katrine Chow
//CS 467 Summer 2025
//Description: This script enables credit roll in the Win scene, which is essentially text scrolling vertically up the screen
//Referenced the following YouTube tutorial:
//skGameDev [skgamedev]. (2024, October 3). How to Make a Rolling CREDITS Scene in Unity!!. YouTube.
//https://www.youtube.com/watch?v=Eeee4TU69x4 Accessed 8/5/2025

using UnityEngine;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    public float speed = 50f;
    public float endPoint = 0f;
    private RectTransform rt;
    public GameObject creditRoll;
    public GameObject winScreen;
    public GameObject BG;
    public GameObject endScreen;
    public GameObject endBG;

    private bool stillGoing = false;


    void Start()
    {
        rt = GetComponent<RectTransform>();
        stillGoing = true;
        endPoint = rt.rect.height + Screen.height + 400f;
    }

    public void Continue()
    {
        winScreen.SetActive(false);
        endScreen.SetActive(false);
        BG.SetActive(true);
        creditRoll.SetActive(true);
    }

    void Update()
    {
        if (stillGoing)
        {
            rt.anchoredPosition += new Vector2(0, speed * Time.deltaTime);

            if (rt.anchoredPosition.y >= endPoint)
            {
                stillGoing = false;
                TheEnd();
            }

        }

    }

    void TheEnd()
    {
        endScreen.SetActive(true);
        endBG.SetActive(true);
    }
}
