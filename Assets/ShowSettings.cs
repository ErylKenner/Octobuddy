using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowSettings : MonoBehaviour
{
    public GameObject settings;
    public Button SettingsButton;
    // Start is called before the first frame update
    void Start()
    {
        SettingsButton.onClick.AddListener(delegate {settings.SetActive(!settings.activeSelf);});
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
