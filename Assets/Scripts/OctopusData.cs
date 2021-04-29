using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class OctopusData
{
    public static Dictionary<string, float> Status = new Dictionary<string, float> {
        { "Health", 100.0f }, 
        { "Hunger", 100.0f },
        { "Happiness", 100.0f }
    };

    public static Animation animation = null;
    
    public static Dictionary<string, float> Cooldowns = new Dictionary<string, float> {
        { "Rest", 0.0f }, 
        { "Clean", 0.0f },
        { "Play", 0.0f },
        { "Pet", 0.0f },
        { "Feed", 0.0f }
    };
}
