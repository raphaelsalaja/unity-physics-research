using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUI : MonoBehaviour
{
    [SerializeField] private Text textLablel;
    private void Start()
    {
        string s = 
            "Press space to jump over this gap\nthe longer you hold jump\nthe higher you will go";
        GetComponent<Typewriter>().Run(s, textLablel);
    }
}
