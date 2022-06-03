using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [Header("Colour")]
    [Space]
    [SerializeField] private Color dimColour;
    [SerializeField] private Color onColour;

    [Header("Checkpoint Manager")]
    [Space]
    [SerializeField] private bool reachedCheckpoint;
    [SerializeField] private CheckpointManager checkpointManager;

    private void Start()
    {
        checkpointManager = GameObject.FindGameObjectWithTag("CheckpointManager").GetComponent<CheckpointManager>();

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            checkpointManager.lastCheckpointPos = transform.position;
            reachedCheckpoint = true;
            GetComponent<SpriteRenderer>().color = onColour;
        }

    }
}
