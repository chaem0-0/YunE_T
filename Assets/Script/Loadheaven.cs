using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadheaven : MonoBehaviour
{
    public Object SceneToLoad;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(1);
    }
}