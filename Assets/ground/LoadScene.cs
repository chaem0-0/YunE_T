using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadground: MonoBehaviour
{
    public Object SceneToLoad;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(0);
    }
}
