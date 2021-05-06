using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToMainMenu : MonoBehaviour
{
    public Button MainMenu;

    // Start is called before the first frame update
    void Start()
    {
        MainMenu.onClick.AddListener(delegate {SceneManager.LoadScene("StartScene"); OctopusData.Reset();});
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
