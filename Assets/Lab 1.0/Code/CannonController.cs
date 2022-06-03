using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public GameObject cannonBall;
    public GameObject pivotPoint;
    public GameObject spawnPoint;

    public float angle = 45F;
    public float power = 0f;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - pivotPoint.transform.position;
        angle = Mathf.Atan2(mousePos.x, mousePos.y) * Mathf.Rad2Deg;
        pivotPoint.transform.rotation = Quaternion.Euler(0, 0, -angle);

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Vector2 velo = new Vector2(
                power * Mathf.Sin(angle * Mathf.Deg2Rad),
                power * Mathf.Cos(angle * Mathf.Deg2Rad)
                );

            GameObject go = Instantiate(cannonBall, spawnPoint.transform.position, Quaternion.Euler(0, 0, angle));

            Rigidbody2D rb = go.GetComponent<Rigidbody2D>();

            rb.position = spawnPoint.transform.position;

            rb.velocity = velo;
        }
    }
}