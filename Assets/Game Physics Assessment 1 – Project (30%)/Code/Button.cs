using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public PointEffector2D pointEffector2D;
    public enum Traps
    {
        PointEffector,
        ConveyorBelt
    };
    void Start()
    {
       // pointEffector2D = GetComponent<PointEffectorControl>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "TrapPointEffector")
        {
            other.GetComponent<PointEffectorControl>().Switch();
        }
    }
}
