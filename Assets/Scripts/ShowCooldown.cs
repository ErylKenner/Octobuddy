using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowCooldown : MonoBehaviour
{
    public Text text;
    public string ButtonType;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(OctopusData.Cooldowns[ButtonType] != 0.0f){
            text.text = Mathf.Ceil(OctopusData.Cooldowns[ButtonType]).ToString();
            OctopusData.Cooldowns[ButtonType] = Mathf.Clamp(OctopusData.Cooldowns[ButtonType] - Time.deltaTime, 0, 100);
        } else{
            text.text = ButtonType;
        }
    }
}
