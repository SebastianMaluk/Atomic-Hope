using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text timeText;
    public void Setup()
    {
        gameObject.SetActive(true);
        timeText.text = System.TimeSpan.FromSeconds((int)PlayerPrefs.GetFloat("TimePrefsName")).ToString();
        Cursor.visible = true;
    }
    

    public void RestartButton()
    {
        Debug.Log("Restart");
        SceneManager.LoadScene("Level 1");
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("Title Screen");
    }
}
