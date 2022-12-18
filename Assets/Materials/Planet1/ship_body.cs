using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship_body : MonoBehaviour
{
    Material myMaterial;
    Shader myShader;

    void Start()
    {
        myShader = Shader.Find("My/PostEffects/ship_body");
        myMaterial = new Material(myShader);
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, myMaterial, 0);
    }

    private void OnDisable()
    {
        if (myMaterial)
        {
            DestroyImmediate(myMaterial);
        }
    }
}
