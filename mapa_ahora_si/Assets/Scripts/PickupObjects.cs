using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickupObjects : MonoBehaviour
{
    public GameObject popup;
    public Sprite Object;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject pop = Instantiate(popup, transform.position, Quaternion.identity) as GameObject;
            GameObject.Find("Jugador").GetComponent<Player>().Inventario.Add(this.gameObject);
            this.gameObject.SetActive(false);
            pop.transform.GetChild(0).GetComponent<TextMeshPro>().text = "Key";
            pop.transform.GetChild(0).GetComponent<TextMeshPro>().color = new Color(0.960f, 0.886f, 0.180f);
        }

    }
}
