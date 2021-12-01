using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Golem : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rocks;
    public GameObject Arm;
    public GameObject firepoint1;
    public GameObject firepoint2;
    public GameObject firepoint3;
    public GameObject firepoint4;
    public GameObject firepoint5;
    public GameObject firepoint6;
    public GameObject firepoint7;
    public GameObject firepoint8;
    public Animator animator;
    public GameObject Idle;
    public float vida;
    public float armsrate;
    public float speed;
    public float bodydamage;
    private GameObject player;
    private float time = 0f;
    private Vector3 posicionoriginal;
    private float rotation;
    //private GameObject canvas;
    //private Text text;
    //public float start_time;
    //public float end_time;
    //public GameOverScreen GameOverScreen;


    void Start()
    {
        player = GameObject.Find("Jugador");
        //canvas = GameObject.Find("Canvasenemy");
        //text = GameObject.Find("Bossvida").GetComponent<Text>();
        posicionoriginal = transform.position;
        //canvas.SetActive(false);
        //start_time = 0f;
        time =0f;
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        //text.text = vida.ToString();
        time += Time.deltaTime;
        Vector3 diff = player.transform.position - transform.position;
        diff.Normalize();

       // float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(0f, 0f ,rot_z);
        

        float Dist = Vector3.Distance(player.transform.position, transform.position);
        if (Dist <= 10f)
        {
            //canvas.SetActive(true);
            //time = 0f;
            

        }
        else
        {
           // canvas.SetActive(false);
        }
        if (Dist <= 10f && time >= armsrate)
        {
          //  canvas.SetActive(true);
            Rocks();
            time = 0;

        }
        //end_time += Time.deltaTime;
        if (vida <= 0)
        {
           // Debug.Log("You Win");
            //PlayerPrefs.SetFloat("TimePrefsName", end_time);
            //Debug.Log(end_time);
            //GameOverScreen.Setup();
            //SceneManager.LoadScene(3);
            //Destroy(this.gameObject);
            //UnityEditor.EditorApplication.isPlaying = false;

        }
    }

    void Rocks()
    {
        animator.SetTrigger("Attack");
        GameObject rock = Instantiate(rocks, firepoint1.transform.position, firepoint1.transform.rotation);
        GameObject rock1 = Instantiate(rocks, firepoint2.transform.position, firepoint2.transform.rotation);
        GameObject rock2 = Instantiate(rocks, firepoint3.transform.position, firepoint3.transform.rotation);
        GameObject rock3 = Instantiate(rocks, firepoint4.transform.position, firepoint4.transform.rotation);
        GameObject rock4 = Instantiate(rocks, firepoint5.transform.position, firepoint5.transform.rotation);
        GameObject rock5 = Instantiate(rocks, firepoint6.transform.position, firepoint6.transform.rotation);
        GameObject rock6 = Instantiate(rocks, firepoint7.transform.position, firepoint7.transform.rotation);
        GameObject rock7 = Instantiate(rocks, firepoint8.transform.position, firepoint8.transform.rotation);
        

    }
    void Mover() 
    {

    }
    void Atacar() 
    {
        
    }
}
