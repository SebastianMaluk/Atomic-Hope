using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public float Range;
    public float rockforce;
    public int damage;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player e = collision.gameObject.GetComponent<Player>();
            e.vida -= damage;
        }
        Destroy(this.gameObject);
    }
    private void Start()
    {
        
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * rockforce, ForceMode2D.Impulse);
    }
}
