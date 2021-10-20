using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int vidas;
    public float velocidad;
    public GameObject player;
    public float MinDist;
    public int Damage;
    public float attackrate;
    private float time=0f;
    public GameObject[] Drops;
    public float droprate;
   
    
    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Jugador");
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        time += Time.deltaTime;
        float Dist = Vector3.Distance(player.transform.position, transform.position);
        if (Dist <= MinDist)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, velocidad);
        }
        if(vidas<=0)
        {
           
            int ran = Random.Range(0, Drops.Length);
            if (Random.Range(0f, 1f) <= droprate)
            {
                Instantiate(Drops[ran], this.gameObject.transform.position, Quaternion.identity);
            }
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            if (time >= attackrate)
            {
                Player p = collision.gameObject.GetComponent<Player>();
                p.vida -= Damage;
                time -= attackrate;
            }

        }
    }
    
  







}
