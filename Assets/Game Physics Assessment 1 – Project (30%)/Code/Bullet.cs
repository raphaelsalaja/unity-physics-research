using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("Stats")]
    [Space]
    public float speed;
    public int damage;

    [Header("Collision")]
    [Space]
    public float distance;
    public LayerMask whatIsSolid;
    private Rigidbody2D rigidbody2D;
    private Vector2 target;

    [Header("Player")]
    [Space]
    public Transform player;
    public P_Movement playerObject;
    private CheckpointManager CheckpointManager;
    private GameController GameController;
    public GameObject hitWall;

    public void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

        playerObject = GameObject.FindGameObjectWithTag("Player").GetComponent<P_Movement>();

        player = GameObject.FindGameObjectWithTag("Player").transform;

        target = new Vector2(player.position.x, player.position.y);

        Vector2 moveDir = (player.transform.position - transform.position).normalized * speed;

        rigidbody2D.velocity = new Vector2(moveDir.x, moveDir.y);

        CheckpointManager = GameObject.FindGameObjectWithTag("CheckpointManager").GetComponent<CheckpointManager>();

        GameController = GameObject.FindGameObjectWithTag("Game Controller").GetComponent<GameController>();
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            GameController.deaths += 1;
            CheckpointManager.Respawn(coll);
            DestroyProjectile();
        }
        if (coll.gameObject.tag == "Wall")
        {
            DestroyProjectile();
        }
    }

    private void DestroyProjectile()
    {
        ChooseBulletHit();
        Destroy(gameObject);
    }

    private void ChooseBulletHit()
    {
        float RandomValue = UnityEngine.Random.value;
        if (RandomValue <= 0.2)
        {
            FindObjectOfType<AudioManager>().Play("BulletHit");
        }
        else if (RandomValue >= 0.2 && RandomValue < 0.4)
        {
            FindObjectOfType<AudioManager>().Play("BulletHit2");
        }
        else if (RandomValue >= 0.4 && RandomValue < 0.8)
        {
            FindObjectOfType<AudioManager>().Play("BulletHit3");
        }
        else if (RandomValue >= 0.8 && RandomValue <= 1)
        {
            FindObjectOfType<AudioManager>().Play("BulletHit4");
        }
    }

    public void SetSpeed(float x)
    {
        speed = x;
    }
}