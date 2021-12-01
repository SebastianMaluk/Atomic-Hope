using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofre : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Drops;
    public Sprite newsprite;
    public GameObject Idle;
    private SpriteRenderer SP;
    public Animator animator;
    public bool Is_Open = false;
    void Start()
    {
        SP = Idle.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player" && Is_Open==false) 
        {
            OpenChest();
        }
    }
    void OpenChest() 
    {
        
        Is_Open = true;
        animator.SetBool("Is_open", Is_Open);
        Idle.GetComponent<Animator>().enabled = false;
        SP.sprite = newsprite;
        int ran = Random.Range(0, Drops.Length);
        
        Instantiate(Drops[ran], this.gameObject.transform.position+new Vector3(0f,1f,0f), Quaternion.identity);
        

    }
}
