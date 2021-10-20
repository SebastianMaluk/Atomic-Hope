using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text timeText;
    public void Setup(float end_time)
    {
        gameObject.SetActive(true);
        timeText.text = System.TimeSpan.FromSeconds((int)Time.timeSinceLevelLoad).ToString();
        Cursor.visible = true;
    }
    
    public void RestartButton()
    {
        Debug.Log("Restart");
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    public void ExitButton()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
