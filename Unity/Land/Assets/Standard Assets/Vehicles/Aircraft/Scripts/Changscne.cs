using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Changscne : MonoBehaviour
{
    // Start is called before the first frame update
    public void nextscence(string scene_name)
    {
        Debug.Log("Onclick");
        SceneManager.LoadScene(scene_name);

    }

    // Update is called once per frame
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
