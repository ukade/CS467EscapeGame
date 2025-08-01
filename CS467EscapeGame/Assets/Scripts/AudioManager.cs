//Katrine Chow
//CS 467 Summer 2025
//Description: This creates an AudioManager GameObject which acts as a hub for all things audio -
//background music (bgm) and sound effects (sfx)

using UnityEngine;

//This code referenced and is adapted from the following resource:
//Rehope Games [RehopeGames]. How to Add MUSIC and SOUND EFFECTS to a Game in Unity | Unity 2D Platformer Tutorial #16.
//YouTube. https://www.youtube.com/watch?v=N8whM1GjH4w Accessed 7/29/2025
//
//Also referenced how to type to movement keys from the following resource:
//Omogonix [Omogonix]. How to Add Footsteps Sounds in Unity. YouTube. 
//https://www.youtube.com/watch?v=uNYF1gsvD1A Accessed 7/30/2025
public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource bgmSource;
    [SerializeField] AudioSource sfxSource;

    //Defines the background and sound effect clips that we will be using in the game
    public AudioClip bgm;
    public AudioClip footsteps;
    public AudioClip solved;

    public float stepRate = 0.5f;
    public float stepCoolDown;

    private void Start()
    {
        //Starts the game with background music
        //Remember to check that there is an AudioListener attached somewhere, otherwise nothing plays :( )
        bgmSource.clip = bgm;
        bgmSource.Play();
    }

    public void PlaySFX(AudioClip sfxClip)
    {
        stepCoolDown -= Time.deltaTime;
        if ((Input.GetAxis("Horizontal") != 0f || Input.GetAxis("Vertical") != 0f) && stepCoolDown < 0f)
        {
            sfxSource.pitch = 1f + Random.Range(-0.2f, 0.2f);
            sfxSource.PlayOneShot(sfxClip, 0.9f);
            stepCoolDown = stepRate;
        }
    }
}
