using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LastScore : MonoBehaviour
{
    public GameController gc;
    [Header("Stats")]
    [Space]
    public Text Results_Text;
    public int fragments = 0;
    public int grade = 0;

    private void Start()
    {
        gc = GameObject.FindGameObjectWithTag("Game Controller").GetComponent<GameController>();
        fragments = gc.fragmentsCollected;
        grade = gc.grade;
    }

    private void Update()
    {
        Results_Text.text = "Fragments collected: " + fragments + "\nGrade: " + grade;
    }
}