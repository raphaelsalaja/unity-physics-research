using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharcterControl : MonoBehaviour
{

    public int speed = 1;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            // transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}
