using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickupPowerups : MonoBehaviour
{
    public GameObject popup;
    private GameObject player;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject pop = Instantiate(popup, transform.position, Quaternion.identity) as GameObject;
            if (this.gameObject.tag == "PVida")
            {
                GameObject.Find("Jugador").GetComponent<Player>().vida=100;
                pop.transform.GetChild(0).GetComponent<TextMeshPro>().text = "Health Potion";
                pop.transform.GetChild(0).GetComponent<TextMeshPro>().color = new Color(0.866f, 0.313f, 0.294f);
            }
            else if (this.gameObject.tag == "PVelocidad") 
            {
                GameObject.Find("Jugador").GetComponent<Movimiento>().speed=1.1f* GameObject.Find("Jugador").GetComponent<Movimiento>().speed;
                pop.transform.GetChild(0).GetComponent<TextMeshPro>().text = "+10% Speed";
                pop.transform.GetChild(0).GetComponent<TextMeshPro>().color = new Color(0.294f, 0.803f, 0.866f);
            }
            Destroy(pop, 2f);
            this.gameObject.SetActive(false);
        }

    }
}
