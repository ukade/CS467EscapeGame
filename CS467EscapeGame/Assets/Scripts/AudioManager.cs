using UnityEngine;

//This code referenced and is adapted from the following resource:
//Rehope Games [RehopeGames]. How to Add MUSIC and SOUND EFFECTS to a Game in Unity | Unity 2D Platformer Tutorial #16.
//YouTube. https://www.youtube.com/watch?v=N8whM1GjH4w Accessed 7/29/2025
public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource bgmSource;
    [SerializeField] AudioSource effectsSource;

    //Defines the background and sound effect clips that we will be using in the game
    public AudioClip bgm;
    public AudioClip footstep;
    public AudioClip solved;

    private void Start()
    {
        //Starts the game with background music
        //Remember to check that there is an AudioListener attached somewhere, otherwise nothing plays :( )
        bgmSource.clip = bgm;
        bgmSource.Play();
    }
}
