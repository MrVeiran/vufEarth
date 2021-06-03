using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShadeEarth : MonoBehaviour
{
    public MeshRenderer earth;
    public Slider slide;
    public GameObject objforShade;

    // Update is called once per frame
    public void OnEdit()
    {
        Color color = earth.material.color;
        color.r = slide.value;
        color.g = slide.value;
        color.b = slide.value;
        if (slide.value > 0.1f)
        {
            earth.material.color = color;
            earth.material.SetColor("__EmissionColor", color);
            if (slide.value <= 0.3f)
            {
                objforShade.SetActive(true);
            }
            if (slide.value > 0.3f)
            {
                objforShade.SetActive(false);
            }
        }
        
    }
}
