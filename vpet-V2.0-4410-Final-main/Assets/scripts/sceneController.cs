using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneController : MonoBehaviour
{
    public bool isBrushUnlocked;
    public bool isBrushSpawned; // check if brush spawned, if so stop spawning
    public GameObject Brush; // call game object brush

    // Start is called before the first frame update
    void Start()
    {
        isBrushSpawned = false;
        //petVars scpVars = FindObjectOfType<petVars>();
        //if (scpVars != null)// debug
        //{
        //    Debug.Log(" File found! Current affection: " + scpVars.affection + " Current hunger: " + scpVars.hunger);
        //}
        //else
        //{
        //    Debug.LogError("File not found in Start fxn:(");
        //}
    }

    // Update is called once per frame
    void Update()
    {
        petVars scpVars = FindObjectOfType<petVars>();

        switch (scpVars.friendRank)
        {
            case 0:
                //Debug.Log("Friendship is 0!");
                break;
            case 1:
                Debug.Log("Friendship is 1!");
                isBrushUnlocked = true;
                break;
            default:
                //Debug.Log("Friendship is not 1 or 0.");
                break;
        }
        // Spawn brush whrn unlocked and not already spwaned.
        // prevents infinite brushes
        if (isBrushUnlocked && !isBrushSpawned)
        {
            Instantiate(Brush);
            isBrushSpawned = true;
        }
    }

    

}
