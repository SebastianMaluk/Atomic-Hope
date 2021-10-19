using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opendoor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            foreach (GameObject i in collision.gameObject.GetComponent<Player>().Inventario)
            {

                if (i.gameObject.name == "Key(Clone)")
                {

                        Destroy(i);
                        Destroy(this.gameObject);

                    

                }
            }
        } 
    }
}
