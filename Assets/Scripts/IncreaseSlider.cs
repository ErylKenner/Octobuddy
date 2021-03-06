using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncreaseSlider : MonoBehaviour
{
    public GameObject GameOver;
    public Animator Octopus;
    public Button RestButton, CleanButton, PlayButton, PetButton, FeedButton;

    // Start is called before the first frame update
    void Start()
    {
        Octopus.SetInteger("Color", OctopusData.Color);
        RestButton.onClick.AddListener(delegate {HandleButtonClick("Rest", 20, 0, 20, 20); });
        CleanButton.onClick.AddListener(delegate {HandleButtonClick("Clean", 10, 0, 0, 20); });
        PlayButton.onClick.AddListener(delegate {HandleButtonClick("Play", 10, -10, 20, 20); });
        PetButton.onClick.AddListener(delegate {HandleButtonClick("Pet", 0, 0, 5, 10); });
        FeedButton.onClick.AddListener(delegate {HandleButtonClick("Feed", 0, 25, 10, 20); });
    }

    // Update is called once per frame
    void Update()
    {
        Octopus.SetFloat("Health", OctopusData.Status["Health"]);
        Octopus.SetFloat("Hunger", OctopusData.Status["Hunger"]);
        Octopus.SetFloat("Happiness", OctopusData.Status["Happiness"]);
        if (OctopusData.Status["Health"] <= 0.0f || OctopusData.Status["Hunger"] <= 0.0f || OctopusData.Status["Happiness"] <= 0.0) {
            GameOver.SetActive(true);
        }
    }

    public static void HandleButtonClick(string attribute, float healthIncrease, float hungerIncrease, float happinessIncrease, float cooldown){
        if (OctopusData.Cooldowns[attribute] == 0.0f) {
            OctopusData.Status["Health"] += healthIncrease;
            OctopusData.Status["Health"] = Mathf.Clamp(OctopusData.Status["Health"], 0, 100);
            OctopusData.Status["Hunger"] += hungerIncrease;
            OctopusData.Status["Hunger"] = Mathf.Clamp(OctopusData.Status["Hunger"], 0, 100);
            OctopusData.Status["Happiness"] += happinessIncrease;
            OctopusData.Status["Happiness"] = Mathf.Clamp(OctopusData.Status["Happiness"], 0, 100);
            OctopusData.Cooldowns[attribute] = cooldown;
        }
    }
}
