using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupAmmo : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gun;
    public int BulletCount;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            string gunname = gun.name + "(Clone)";
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
        }
        
    }
}
