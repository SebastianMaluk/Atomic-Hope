using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
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
    public void TitleScreenButton()
    {
        Debug.Log("Title Screen");
        SceneManager.LoadScene("Title Screen");
    }

}
