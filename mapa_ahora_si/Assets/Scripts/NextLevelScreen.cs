using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScreen : MonoBehaviour
{
    public void Setup()
    {
        gameObject.SetActive(true);
        Cursor.visible = true;
    }

    // Update is called once per frame
    public void Update()
    {
        
    }
    public void NextLevelButton()
    {
        Debug.Log("Next Level");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}

