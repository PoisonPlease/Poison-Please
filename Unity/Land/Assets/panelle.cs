﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class panelle : MonoBehaviour
{
    /*
    public GameObject Panel;
    public void OpenPanel()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);
        }
    }
    */
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
