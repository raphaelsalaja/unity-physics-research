using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{


    public int speed = 1;
    public Rigidbody2D rigidbody;
    public int jumpVelocity;
    public ForceMode2D force;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // For Physics
    void FixedUpdate()
    {
        // Players moves up 
        if (Input.GetKey(KeyCode.W)) {
            //transform.position += Vector3.up * speed * Time.deltaTime;
            rigidbody.AddForce(Vector3.up * jumpVelocity, force);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

    }

}
