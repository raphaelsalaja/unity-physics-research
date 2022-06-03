using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class RandomColour : MonoBehaviour
{
    private int hue;
    [SerializeField] private PostProcessVolume volume;
    private ColorGrading colorGrading = null;

    // Start is called before the first frame update
    private void Start()
    {
        PostProcessVolume volume = gameObject.GetComponent<PostProcessVolume>();
        volume.profile.TryGetSettings(out colorGrading);
        hue = Random.Range(-180, 180);
        colorGrading.hueShift.value = hue;
    }

    // Update is called once per frame
    private void Update()
    {
    }
}