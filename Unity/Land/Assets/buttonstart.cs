using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startbutton : MonoBehaviour
{

    public void onClickNextScene()
    {
        SceneManager.LoadScene("Ani_select");
    }

}
