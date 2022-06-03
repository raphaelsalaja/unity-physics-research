using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject box;
    public Transform pos;
    public float spawnTime = 3f;
    public float t; // i=0.

    private void Start()
    {
        pos = GetComponent<Transform>();
    }

    private void Update()
    {
        t = t + Time.deltaTime;
        if (t >= 2.5f)
        {
            Instantiate(box, pos);
            t = 0f;
        }
    }
}