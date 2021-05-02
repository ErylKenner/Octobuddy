using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CustomizeGame : MonoBehaviour
{
    public Button FinishButton, BackButton;
    // Start is called before the first frame update
    void Start()
    {
        FinishButton.onClick.AddListener(delegate {SceneManager.LoadScene("MainScene");});
        BackButton.onClick.AddListener(delegate {SceneManager.LoadScene("StartScene");});
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
