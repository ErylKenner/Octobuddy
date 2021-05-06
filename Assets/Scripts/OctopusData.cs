using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class OctopusData
{
    public static string Name;
    public static Animation Animation = null;
    public static int Color;

    public static Dictionary<string, float> Status = new Dictionary<string, float> {
        { "Health", 100.0f }, 
        { "Hunger", 100.0f },
        { "Happiness", 100.0f }
    };
    
    public static Dictionary<string, float> Cooldowns = new Dictionary<string, float> {
        { "Rest", 0.0f }, 
        { "Clean", 0.0f },
        { "Play", 0.0f },
        { "Pet", 0.0f },
        { "Feed", 0.0f }
    };

    public static void Reset(){
        Status["Health"] = 100.0f;
        Status["Hunger"] = 100.0f;
        Status["Happiness"] = 100.0f;
        Cooldowns["Rest"] = 0.0f;
        Cooldowns["Clean"] = 0.0f;
        Cooldowns["Play"] = 0.0f;
        Cooldowns["Pet"] = 0.0f;
        Cooldowns["Feed"] = 0.0f;
    }
}
