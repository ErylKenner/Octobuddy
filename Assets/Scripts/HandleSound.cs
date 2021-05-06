using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleSound : MonoBehaviour
{
    public AudioSource BackgroundMusic;
    public Slider SoundSlider;
    // Start is called before the first frame update
    void Start()
    {
        SoundSlider.onValueChanged.AddListener(delegate {BackgroundMusic.volume = SoundSlider.value;});
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
