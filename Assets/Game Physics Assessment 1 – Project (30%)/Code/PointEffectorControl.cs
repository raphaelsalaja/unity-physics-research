using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointEffectorControl : MonoBehaviour
{

    private bool state = true;


    public void Switch()
    {
        state = !state;
        if (state)
        {
            print("IM ON");
        }
        else
        {
            print("IM OFF");
        }
    }
}
