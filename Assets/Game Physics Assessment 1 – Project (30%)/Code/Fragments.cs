using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fragments : MonoBehaviour
{
    private GameController GameController;
    private static Star instance;

    private void Start()
    {
        GameController = GameObject.FindGameObjectWithTag("Game Controller").GetComponent<GameController>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameController.fragmentsCollected += 1;
            Destroy(gameObject);
            FindObjectOfType<AudioManager>().Play("StarCollect");
        }
    }
}