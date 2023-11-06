using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public static int difficulty;
    public void OnPlayButton()
    {
        difficulty = dropdown.value;
        PlayerPrefs.SetInt("difficulty", difficulty);
        SceneManager.LoadScene("_Scene_0");
    }

    public void OnQuitButton()
    {
        Application.Quit();
    }

}
