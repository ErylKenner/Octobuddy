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
        Color1Button.onClick.AddListener(delegate {OctopusData.Animation = GetAnimation(Color1Button.GetComponentInChildren<Text>().text);});
        Color2Button.onClick.AddListener(delegate {OctopusData.Animation = GetAnimation(Color2Button.GetComponentInChildren<Text>().text);});
        Color3Button.onClick.AddListener(delegate {OctopusData.Animation = GetAnimation(Color3Button.GetComponentInChildren<Text>().text);});
        Color4Button.onClick.AddListener(delegate {OctopusData.Animation = GetAnimation(Color4Button.GetComponentInChildren<Text>().text);});
        Color5Button.onClick.AddListener(delegate {OctopusData.Animation = GetAnimation(Color5Button.GetComponentInChildren<Text>().text);});
        Color6Button.onClick.AddListener(delegate {OctopusData.Animation = GetAnimation(Color6Button.GetComponentInChildren<Text>().text);});
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Animation GetAnimation(string color){
        return new Animation();
    }
}
