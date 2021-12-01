using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Range;
    public float bulletforce;
    public int damage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Enemy")
        {
            Enemy e = collision.gameObject.GetComponent<Enemy>();
            e.vidas -= damage;
        }
        if (collision.gameObject.tag == "Boss")
        {
            Boss e = collision.gameObject.GetComponent<Boss>();
            e.vida -= damage;
        }
        if (collision.gameObject.tag == "Golem")
        {
            Golem e = collision.gameObject.GetComponent<Golem>();
            e.vida -= damage;
        }
        Destroy(this.gameObject);
    }
    private void Start()
    {
        Destroy(gameObject, Range);
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * bulletforce, ForceMode2D.Impulse);
    }

    
}
