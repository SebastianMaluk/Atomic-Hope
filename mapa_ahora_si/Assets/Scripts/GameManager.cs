using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
        SceneManager.UnloadSceneAsync(0);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    // Update is called once per frame
    public void LoadGame()
    {
        SceneManager.UnloadSceneAsync(1);
        SceneManager.LoadSceneAsync(2, LoadSceneMode.Single);
        
    }
}
