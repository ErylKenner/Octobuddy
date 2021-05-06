using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public Button NewGameButton, QuitButton;

    // Start is called before the first frame update
    void Start()
    {
        NewGameButton.onClick.AddListener(delegate {SceneManager.LoadScene("CustomizeScene");});
        QuitButton.onClick.AddListener(Application.Quit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
