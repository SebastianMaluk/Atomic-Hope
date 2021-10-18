using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int vida;
    public List<GameObject> Inventario = new List<GameObject>();
    public Text texto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        texto.text = vida.ToString();
        if (vida <= 0) 
        {
            Destroy(this.gameObject);
        }
    }
}
