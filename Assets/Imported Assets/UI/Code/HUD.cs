using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUD : MonoBehaviour
{
    [HideInInspector]
    public GameController gc;
    private int fragments = 0;
    private int deaths = 0;
    [Header("Texts")]
    public Text fragmentsText;
    public Text DeathText;

    private void Awake()
    {
        gc = GameObject.FindGameObjectWithTag("Game Controller").GetComponent<GameController>();
        fragments = gc.totalFragments;
    }

    private void Update()
    {
        deaths = gc.deaths;
        fragmentsText.text = "Fragments: " + gc.fragmentsCollected + " / " + fragments;
        DeathText.text = "Deaths: " + deaths + " / " + gc.deathsRemaining;
    }
}