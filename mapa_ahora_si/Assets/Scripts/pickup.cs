using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public GameObject gunprefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject gunholder = GameObject.Find("Jugador").transform.GetChild(1).gameObject;
        if (collision.gameObject.tag == "Player")
        {
            Vector3 pos = gunholder.transform.position;
            GameObject gun = Instantiate(gunprefab, pos, gunholder.transform.rotation);
            //gun.transform.SetParent(GameObject.Find("Player").transform);
            gun.transform.SetParent(gunholder.transform);
            GameObject j = GameObject.Find("Jugador");
            string gunammo = gun.name;
            foreach (GameObject i in j.GetComponent<Player>().Inventario)
            {

                if (i.gameObject.tag=="Ammo")
                {
                    if (i.GetComponent<pickupAmmo>().gun.name + "(Clone)" ==gun.name) 
                    {
                        gun.GetComponent<GunSystem>().magazine += i.GetComponent<pickupAmmo>().BulletCount;
                        Destroy(i);
                        
                    }
                    
                }
            }
            GameObject.Find("GunHolder").GetComponent<weaponswitch>().AddWeapon(gun);
            Destroy(this.gameObject);
           
        }
       

        
    }

}
