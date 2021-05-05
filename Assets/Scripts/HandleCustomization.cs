using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleCustomization : MonoBehaviour
{
    public InputField Name;
    public Button Color1Button, Color2Button, Color3Button, Color4Button, Color5Button, Color6Button;
    // Start is called before the first frame update
    void Start()
    {
        Name.onValueChanged.AddListener(delegate {OctopusData.Name = Name.text;});
        Color1Button.onClick.AddListener(delegate {OctopusData.Animation = GetAnimation(Color1Button.name);});
        Color2Button.onClick.AddListener(delegate {OctopusData.Animation = GetAnimation(Color2Button.name);});
        Color3Button.onClick.AddListener(delegate {OctopusData.Animation = GetAnimation(Color3Button.name);});
        Color4Button.onClick.AddListener(delegate {OctopusData.Animation = GetAnimation(Color4Button.name);});
        Color5Button.onClick.AddListener(delegate {OctopusData.Animation = GetAnimation(Color5Button.name);});
        Color6Button.onClick.AddListener(delegate {OctopusData.Animation = GetAnimation(Color6Button.name);});
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Animation GetAnimation(string color){
        return new Animation();
    }
}
