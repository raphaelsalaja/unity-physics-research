using UnityEngine;

public class P_KillPlayer : MonoBehaviour
{
    private CheckpointManager CheckpointManager;
    private GameController GameController;

    private void Start()
    {
        CheckpointManager = GameObject.FindGameObjectWithTag("CheckpointManager").GetComponent<CheckpointManager>();
        GameController = GameObject.FindGameObjectWithTag("Game Controller").GetComponent<GameController>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameController.deaths += 1;
            CheckpointManager.Respawn(other);
        }
    }
}