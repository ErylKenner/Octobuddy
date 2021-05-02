using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DecreaseOverTime : MonoBehaviour
{
    public string SliderType;
    public Slider slider;
    public float Speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OctopusData.Status[SliderType] = OctopusData.Status[SliderType] - Time.deltaTime * Speed;
        slider.value = OctopusData.Status[SliderType];
    }
}
