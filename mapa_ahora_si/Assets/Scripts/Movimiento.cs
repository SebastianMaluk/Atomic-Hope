using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    Vector2 movement;
    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        movement.x=Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (movement.x < 0) 
        {
            gameObject.GetComponent<SpriteRenderer>().flipX=true;
        }
        else if(movement.x>0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
