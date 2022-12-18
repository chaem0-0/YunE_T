using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMultiPass : MonoBehaviour
{
    Shader myShader;        // image effect shader 
    Material myMaterial; 
    int pass = 0;  

    void Start()
    {
        myShader = Shader.Find("My/PostEffects/CameraMultiPass");    // image effect shader file must have been created
        myMaterial = new Material(myShader);                
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (pass < 6)
            {
                pass++;
            }
            else
            {
                pass=0;
            }
        }

    }

    public void OnClick_ChangePass()
    {
        if (pass < 6)
            {
                pass++;
            }
            else
            {
                pass=0;
            }

    }
    


    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, myMaterial, pass);  // can choose second pass
    }

    private void OnDisable()
    {
        if (myMaterial)
        {
            DestroyImmediate(myMaterial);
        }
    }
}

