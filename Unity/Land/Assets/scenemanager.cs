using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void NextScence(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }

    // Update is called once per frame
    public void QuitGame ()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
