using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pickupAmmo : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gun;
    public int BulletCount;
    public GameObject popup;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            string gunname = gun.name + "(Clone)";

            GameObject pop = Instantiate(popup, transform.position, Quaternion.identity) as GameObject;

            if (GameObject.Find("GunHolder").GetComponent<weaponswitch>().guns.Count == 0)
            {
                GameObject.Find("Jugador").GetComponent<Player>().Inventario.Add(this.gameObject);
                this.gameObject.SetActive(false);
            }
            foreach (GameObject i in GameObject.Find("GunHolder").GetComponent<weaponswitch>().guns)
            {


                if (gunname == i.name)
                {
                    i.GetComponent<GunSystem>().magazine += BulletCount;

                }
                else
                {
                    GameObject.Find("Jugador").GetComponent<Player>().Inventario.Add(this.gameObject);//Aqui hacer que las balas vayan al inventario.
                }
                this.gameObject.SetActive(false);
            }

            pop.transform.GetChild(0).GetComponent<TextMeshPro>().text = "x"+BulletCount.ToString()+" Ammo";
            pop.transform.GetChild(0).GetComponent<TextMeshPro>().color = Color.grey;
            Destroy(pop, 2f);

        }
        
    }
}
