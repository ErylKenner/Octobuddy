using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleCustomization : MonoBehaviour
{
    public InputField Name;
    public GameObject Outline;
    public Button Color1Button, Color2Button, Color3Button, Color4Button, Color5Button, Color6Button;
    // Start is called before the first frame update
    private Dictionary<string, Vector2> outlinePositions = new Dictionary<string, Vector2> {
        { "red", new Vector2(264f, 181f) }, 
        { "blue", new Vector2(395f, 181f) },
        { "green", new Vector2(525f, 181f) }, 
        { "yellow", new Vector2(264f, 50f) }, 
        { "purple", new Vector2(395f, 50f) }, 
        { "orange", new Vector2(525f, 50f) }, 
    };
    private Dictionary<string, int> colorIndex = new Dictionary<string, int> {
        { "red", 0 }, 
        { "blue", 1 },
        { "green", 2 }, 
        { "yellow", 3 }, 
        { "purple", 4 }, 
        { "orange", 5 }, 
    };

    void Start()
    {
        Name.onValueChanged.AddListener(delegate {OctopusData.Name = Name.text;});
        Color1Button.onClick.AddListener(delegate {HandleClick(Color1Button);});
        Color2Button.onClick.AddListener(delegate {HandleClick(Color2Button);});
        Color3Button.onClick.AddListener(delegate {HandleClick(Color3Button);});
        Color4Button.onClick.AddListener(delegate {HandleClick(Color4Button);});
        Color5Button.onClick.AddListener(delegate {HandleClick(Color5Button);});
        Color6Button.onClick.AddListener(delegate {HandleClick(Color6Button);});
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void HandleClick(Button button){
        //OctopusData.Animation = GetAnimation(button.name);
        OctopusData.Color = colorIndex[button.name];
        Outline.GetComponent<RectTransform>().anchoredPosition = outlinePositions[button.name];
    }

    Animation GetAnimation(string color){
        return new Animation();
    }
}
