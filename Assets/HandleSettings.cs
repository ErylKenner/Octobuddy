using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleSettings : MonoBehaviour
{
    public Button SettingButton;
    public GameObject Options;
    // Start is called before the first frame update
    void Start()
    {
        SettingButton.onClick.AddListener(delegate {Options.SetActive(!Options.activeSelf); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
