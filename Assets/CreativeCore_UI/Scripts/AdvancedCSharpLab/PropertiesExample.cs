using UnityEngine;
using System.Collections;

// Renamed to PlayerStats to avoid name conflict with other scripts
public class PlayerStats
{
    private int experience;

    // Experience is a basic property
    public int Experience
    {
        get
        {
            return experience;
        }
        set
        {
            experience = value;
        }
    }

    // Property that converts experience into player level
    public int Level
    {
        get
        {
            return experience / 1000;
        }
        set
        {
            experience = value * 1000;
        }
    }

    // Example of an auto-implemented property
    public int Health { get; set; }
}

public class PropertiesExample : MonoBehaviour 
{
    void Start () 
    {
        PlayerStats myPlayer = new PlayerStats();

        // Properties can be used just like variables
        myPlayer.Experience = 5000;
        int x = myPlayer.Experience;

        // Displaying both experience and the calculated level
        Debug.Log("Player experience: " + x);
        Debug.Log("Player level: " + myPlayer.Level);
    }
}