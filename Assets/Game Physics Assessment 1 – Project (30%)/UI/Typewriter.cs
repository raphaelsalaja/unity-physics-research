using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Typewriter : MonoBehaviour
{
    [SerializeField ]private float typewriterSpeed = 50f;
    public void Run(string textToType, Text textLablel)
    {
        StartCoroutine(TypeText(textToType, textLablel));
    }
    private IEnumerator TypeText(string textToType, Text textLablel)
    {
        float t = 0;
        int charIndex = 0;
        while (charIndex < textToType.Length)
        {
            textLablel.text = string.Empty;

            t += Time.deltaTime * typewriterSpeed;

            charIndex = Mathf.FloorToInt(t);
            charIndex = Mathf.Clamp(charIndex, 0, textToType.Length);

            textLablel.text = textToType.Substring(0, charIndex);
            yield return null;
        }
        textLablel.text = textToType;
    }
}
