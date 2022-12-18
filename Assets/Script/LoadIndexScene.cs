using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadIndexScene : MonoBehaviour
{
    public Object OriginalScene;
    void Update()
    {
        int i = 0;

        if (Input.GetKeyDown(KeyCode.U))
        {
            i++;
            if (i%2==1)
            {
                SceneManager.LoadScene("Index");
            }
            else if (i % 2 == 0)
            {
                SceneManager.LoadScene(OriginalScene.name);
            }
        }
    }

}
