/* Part of the following script was generated automatically by Unity. It was adapted to fit our groups project. 
Several of the most relevant sources are mentioned in comments here. 
For a full list of sources please see the attached README page.  */


using UnityEngine;

public class WordSpell : MonoBehaviour
{
    // Relevant Source: https://learn.microsoft.com/en-au/dotnet/csharp/language-reference/builtin-types/arrays
    public GameObject[] letters = new GameObject[12];
    public GameObject[] correctLetters = new GameObject[12];
    
    // Relevant Source: https://docs.unity3d.com/Manual/class-GameObject.html and https://docs.unity3d.com/ScriptReference/GameObject.html
    public GameObject bottleCan;
    public GameObject sodaCan;
    public GameObject waterBottleCan;
    public garbageCan bottleCanScript;
    public garbageCan sodaCanScript;
    public garbageCan waterBottleCanScript;
    public GameObject bedRoll;
    public PuzzleFinish bedRollScript;
    public int correctLetterCount;
    public GameObject firstComparisonLetter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* Used to get the in game objects from name
        Relevant Source:
        https://docs.unity3d.com/Manual/class-GameObject.html */
        bottleCan =  GameObject.Find("GlassBottleRecycleCan");
        sodaCan = GameObject.Find("SodaCanRecycleCan");
        waterBottleCan = GameObject.Find("WaterBottleRecycleCan");
        
        /* Used to get scrips from game objects. Relevant source: 
        https://docs.unity3d.com/ScriptReference/Component.GetComponent.html */
        bottleCanScript = bottleCan.GetComponent<garbageCan>();
        sodaCanScript = sodaCan.GetComponent<garbageCan>();
        waterBottleCanScript = waterBottleCan.GetComponent<garbageCan>();

        // Setting initial letter variable
    }

    // Update is called once per frame
    void Update()
    {

        /* Relevant Sources: Adapted from: https://learn.microsoft.com/en-au/dotnet/csharp/language-reference/statements/iteration-statements
        Published by Microsoft, Accessed on 7/30/25, full cite in the README. */
        foreach (GameObject letter in letters)
        {
            // Setting the initial letter for comparison each time
            if (letter == letters[0])
            {
                firstComparisonLetter = letter;
                correctLetterCount = 1;
            }
            else
            {
                /* Relevant sources:
                https://docs.unity3d.com/Manual/class-GameObject.html
                https://docs.unity3d.com/ScriptReference/Transform.html
                https://docs.unity3d.com/Manual/class-Transform.html
                https://docs.unity3d.com/ScriptReference/Component-transform.html
                https://docs.unity3d.com/ScriptReference/Transform-position.html
                https://docs.unity3d.com/ScriptReference/Vector3.html
                https://docs.unity3d.com/ScriptReference/Vector3-x.html
                See README for fill list of sources cited. */

                /* So as best I can tell the position is a Vector3 in the worldspace so adding an X onto the position should give me the position on the X axis. 
                I cannot find any of these sources that say this directly, but it makes sense that you can reference it as an attribute of position.
                I also feel like I saw this in a Unity Documentation source but I cannot remember where. Transform position returns the X,Y,Z of a GameObject so I should be able to reference X as an attribute.
                
                I noticed on 8/2 when checking Brian's pickup.cs script for object respawn that it uses the X/Y/Z in this fashion but did not see anything in the relevant youtube video for it.
                The professor said I needed to include a citation here for Brian's script as well as the youtube video it is based on even though I arrived at the conclusion that X can be used as an attribute of transform.position myself.
                Including citations here and in the README based on the professor's instruction:

                Matt's Computer Lab. [Matt's Computer Lab]. (2024, December 15). Pick Up and Throw Stuff in Unity 6! 2024 Tutorial.
                https://www.youtube.com/watch?v=fApXEL0xsx4  Accessed: June-August 2025.

                Swanson, Brian. (2025, June-August). *CS467EscapeGame, Pickup.cs Script.* (Version 1.0). Oregon State University.
                https://github.com/ukade/CS467EscapeGame Accessed: July-August 2025.
                */

                if (firstComparisonLetter.transform.position.x < letter.transform.position.x)
                {
                    if (correctLetterCount < 12)
                    {
                        firstComparisonLetter = letter;
                        correctLetterCount +=1;

                    }
                    
                }
                else
                {
                    correctLetterCount = 0;

                }
            }
        }

        // Displaying the green letters if the order becomes correct
        /* Relevant sources for all four below foreach loops: 
        https://learn.microsoft.com/en-au/dotnet/csharp/language-reference/statements/iteration-statements
        https://docs.unity3d.com/Manual/class-GameObject.html
        https://docs.unity3d.com/ScriptReference/GameObject.SetActive.html
        https://docs.unity3d.com/ScriptReference/Component.GetComponent.html
        See attached README for full citations. */
        if (correctLetterCount == 12)
        {
            foreach (GameObject letter in letters)
            {
                letter.SetActive(false);

                // Check if bedroll has been put in tent
                bedRollScript = bedRoll.GetComponent<PuzzleFinish>();
                if (bedRollScript.isCompleted == false)
                {
                    bedRoll.SetActive(true);
                }
            }
            foreach (GameObject letter in correctLetters)
            {
                letter.SetActive(true);
            }

        }

        if (correctLetterCount < 12)
        {
            foreach (GameObject letter in letters)
            {
                letter.SetActive(true);
            }
            foreach (GameObject letter in correctLetters)
            {
                letter.SetActive(false);
            }
        }

    }
}
