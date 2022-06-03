using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int level;
    public int level_s;
    public int deaths;
    public int deathsRemaining = 5;
    public int fragmentsCollected;
    public int totalFragments;
    public int AmountOfFragments;
    public int time;
    public int timeRemaining;
    public int grade;
    private static GameController instance;
    private Transform teleport;
    public Animator transisition;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
        totalFragments = GameObject.FindGameObjectsWithTag("Fragments").Length;
    }

    private void Start()
    {
        totalFragments = GameObject.FindGameObjectsWithTag("Fragments").Length;
    }

    private void Update()
    {
        DontDestroyOnLoad(this);
        //transisition = GameObject.Find("LevelLoader").GetComponentInChildren<Animator>();

        totalFragments = GameObject.FindGameObjectsWithTag("Fragments").Length;
        Fragments();
        WhichLevel();
        level_s = SceneManager.GetActiveScene().buildIndex;
        if (deaths == 10)
        {
            StartCoroutine(LoadLevel(2));
            deaths = 0;
            fragmentsCollected = 0;
        }
    }

    private IEnumerator LoadLevel(int levelIndex)
    {
        deaths = 0;
        fragmentsCollected = 0;
        SceneManager.LoadScene(levelIndex);

        yield return new WaitForSeconds(1);

        transisition.SetTrigger("Start");
        deaths = 0;
        fragmentsCollected = 0;
    }

    private void WhichLevel()
    {
        switch (level_s)
        {
            case 3:
                level = 3;
                break;

            case 4:
                level = 4;
                break;

            case 5:
                level = 5;
                break;
        }
    }

    private void Fragments()
    {
        int half = AmountOfFragments / 2;

        if (totalFragments == 0)
        {
            grade = 3;
        }
        else if (fragmentsCollected >= totalFragments)
        {
            grade = 2;
        }
        else if ((fragmentsCollected <= totalFragments) && fragmentsCollected != 0)
        {
            grade = 1;
        }
        else if (fragmentsCollected == 0)
        {
            grade = 0;
        }
    }
}