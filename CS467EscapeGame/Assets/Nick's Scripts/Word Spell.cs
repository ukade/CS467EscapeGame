/* Part of the following script was generated automatically by Unity. It was adapted to fit our groups project. 
Several of the most relevant sources are mentioned in comments here. 
For a full list of sources please see the attached README page.  */


using UnityEngine;

public class WordSpell : MonoBehaviour
{
    // Relevant Source: https://learn.microsoft.com/en-au/dotnet/csharp/language-reference/builtin-types/arrays
    public GameObject[] letters = new GameObject[12];
    
    // Relevant Source: https://docs.unity3d.com/Manual/class-GameObject.html and https://docs.unity3d.com/ScriptReference/GameObject.html
    public GameObject bottleCan;
    public GameObject sodaCan;
    public GameObject waterBottleCan;
    public garbageCan bottleCanScript;
    public garbageCan sodaCanScript;
    public garbageCan waterBottleCanScript;
    public int totalTrash;
    public GameObject bedRoll;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* Used to get the in game objects from name
        Relevant Source:
        https://docs.unity3d.com/Manual/class-GameObject.html */
        bottleCan =  GameObject.Find("GlassBottleRecycleCan");
        sodaCan = GameObject.Find("SodaCanRecycleCan");
        waterBottleCan = GameObject.Find("WaterBottleRecycleCan");
        bedRoll = GameObject.Find("BedRoll");
        
        /* Used to get scrips from game objects. Relevant source: 
        https://docs.unity3d.com/ScriptReference/Component.GetComponent.html */
        bottleCanScript = bottleCan.GetComponent<garbageCan>();
        sodaCanScript = sodaCan.GetComponent<garbageCan>();
        waterBottleCanScript = waterBottleCan.GetComponent<garbageCan>();
    }

    // Update is called once per frame
    void Update()
    {
        // Totalling up the trash in all the cans.
        totalTrash = bottleCanScript.trashCollected + sodaCanScript.trashCollected + waterBottleCanScript.trashCollected;

        // Relevant Source: https://docs.unity3d.com/Manual/class-GameObject.html
        if (totalTrash == 12)
        {
            if (bedRoll.activeSelf == false)
            {
                bedRoll.SetActive(true);
            }

        }




        
    }
}
