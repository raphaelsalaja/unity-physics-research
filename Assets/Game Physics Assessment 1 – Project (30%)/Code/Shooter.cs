using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private float timeBetweenShots;
    [SerializeField] private float startTimeBetweenShots;
    // public Vector2 player;

    public float power;
    public GameObject bullet;
    public GameObject spawnPoint;
    public P_Movement player;
    public Vector2 playerPosition;

    public enum ShootingState
    {
        ON,
        OFF
    };

    public ShootingState state;

    private void Start()
    {
        state = ShootingState.OFF;
    }

    private void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<P_Movement>();
        switch (state)
        {
            case ShootingState.ON:
                Shoot();
                break;

            case ShootingState.OFF:
                DontShoot();
                break;

            default:
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            state = ShootingState.ON;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            state = ShootingState.OFF;
        }
    }

    public void DontShoot()
    {
        return;
    }

    public void Shoot()
    {
        playerPosition = player.GetPosition();

        if (timeBetweenShots <= 0)
        {
            bullet.GetComponent<Bullet>().SetSpeed(power);
            Instantiate(bullet, transform.position, Quaternion.identity);
            timeBetweenShots = startTimeBetweenShots;
        }
        else
        {
            timeBetweenShots -= Time.deltaTime;
        }
    }
}