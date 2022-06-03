using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityExample : MonoBehaviour
{

    public Vector3 velo;
    public Rigidbody2D rb;
    float launchTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("SPACEBAR");
            rb.velocity = velo;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("R");
            rb.velocity = velo;
            launchTime = Time.time;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OBJECT COLLIDED WITH: " + collision.collider.gameObject.name + " AFTER " + (Time.time - launchTime));

    }


}
