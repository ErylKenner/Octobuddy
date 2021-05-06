using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleBrightness : MonoBehaviour
{
    public GameObject BrightnessBackground;
    public Slider BrightnessSlider;
    // Start is called before the first frame update
    void Start()
    {
        BrightnessSlider.onValueChanged.AddListener(delegate {SetBackground(BrightnessSlider.value);});
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetBackground(float sliderValue) {
        Image image = BrightnessBackground.GetComponent<Image>();
        Color oldColor = image.color;
        image.color = new Color(oldColor.r, oldColor.g, oldColor.b, Mathf.Lerp(0.9f, 0, sliderValue));
    }
}
