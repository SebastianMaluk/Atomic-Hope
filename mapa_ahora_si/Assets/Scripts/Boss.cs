using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rocks;
    public GameObject firepoint;
    public float vida;
    public float rocksrate;
    public float speed;
    public float bodydamage;
    private GameObject player;
    private float time = 0f;
    private GameObject canvas;
    private Text text;
   
    void Start()
    {
        player = GameObject.Find("Jugador");
        canvas = GameObject.Find("Canvasenemy");
        text = GameObject.Find("Bossvida").GetComponent<Text>();
        canvas.SetActive(false);
    }

    // Update is called once per frame
   
    private void FixedUpdate()
    {
        text.text = vida.ToString();
        time += Time.deltaTime;
        Vector3 diff = player.transform.position - transform.position;
        diff.Normalize();

        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);

        float Dist = Vector3.Distance(player.transform.position, transform.position);
        if (Dist <= 10f)
        {
            canvas.SetActive(true);
           
        }
        else
        {
            canvas.SetActive(false);
        }
        if (Dist <= 10f && time>=rocksrate)
        {
            canvas.SetActive(true);
            Rocks();
            time = 0;
            

        }
       
        if (vida <= 0)
        {
            Destroy(this.gameObject);
        }
    }
 
    void Rocks()
    {
        GameObject rock = Instantiate(rocks, firepoint.transform.position,firepoint.transform.rotation);
        
        
    }
}
