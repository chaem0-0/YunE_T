using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO_cockpit : MonoBehaviour
{
    int brightness = -1;
    Renderer MyRenderer;

    // Start is called before the first frame update
    void Start()
    {
        MyRenderer = gameObject.GetComponent<Renderer>();
        MyRenderer.material.SetInt("_Brightness", brightness);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        brightness = -1 * brightness;
        MyRenderer.material.SetInt("_Brightness", brightness);
    }
}
