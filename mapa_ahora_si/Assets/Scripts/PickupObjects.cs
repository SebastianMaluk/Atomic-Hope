using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjects : MonoBehaviour
{
    
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            GameObject.Find("Jugador").GetComponent<Player>().Inventario.Add(this.gameObject);
          
            this.gameObject.SetActive(false);
           
        }

    }
}
