using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int vida;
    public List<GameObject> Inventario = new List<GameObject>();
    public Text texto;
    public GameOverScreen GameOverScreen;
    public float start_time;
    public float end_time;
    // Start is called before the first frame update
    void Start()
    {
        start_time = 0f;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        texto.text = vida.ToString();
        end_time += Time.deltaTime;
        if (vida <= 0) 
        {   
            GameOverScreen.Setup(end_time);
            
        }
    }
}
