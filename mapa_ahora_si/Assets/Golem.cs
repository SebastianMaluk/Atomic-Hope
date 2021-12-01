using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

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
    public GameObject firepoitnA;
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
    private float time2=0f;
    public GameOverScreen GameOverScreen;
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
        StartCoroutine(At1());
        time = 0f;
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        //text.text = vida.ToString();
        time += Time.deltaTime;
        Vector3 diff = player.transform.position - transform.position;
        diff.Normalize();


        if (vida <= 0)
        {
            Debug.Log("You Win");
            
            GameOverScreen.Setup();
            SceneManager.LoadScene(1);
            //Destroy(this.gameObject);
            //UnityEditor.EditorApplication.isPlaying = false;

        }




    }
    IEnumerator At1() 
    {
        while (true)
        {
            float Dist = Vector3.Distance(player.transform.position, transform.position);

            for (int i = 0; i < 3; i++)
            {
                animator.SetBool("isAttacking", true);
                animator.SetTrigger("Attack");
                Invoke("Rocks", 1f);
                yield return new WaitForSeconds(2);
                animator.ResetTrigger("Attack");
            }
            yield return new WaitForSeconds(1);
            var newPos = posicionoriginal + (transform.up * 16f) - (transform.right * 16f);

            while (Vector3.Distance(newPos, transform.position) > 0.01f)
            {
                transform.position = Vector3.MoveTowards(transform.position, newPos, Time.deltaTime * 7f);
                yield return null;
            }

            yield return new WaitForSeconds(2);
            var newPos1 = transform.position - transform.up * 30f;
            animator.SetTrigger("Charge");
            bool ataca = true;
            while (Vector3.Distance(newPos1, transform.position) > 0.01f)
            {
                transform.position = Vector3.MoveTowards(transform.position, newPos1, Time.deltaTime * speed);
                StartCoroutine(Atacar());
                yield return null;
            }

            animator.ResetTrigger("Charge");
            animator.SetTrigger("Discharge");
            yield return new WaitForSeconds(1);

            var newPos2 = posicionoriginal;
            while (Vector3.Distance(newPos2, transform.position) > 0.01f)
            {
                transform.position = Vector3.MoveTowards(transform.position, newPos2, Time.deltaTime * 7f);
                yield return null;
            }
        }


    }
    void Rocks()
    {

        GameObject rock = Instantiate(rocks, firepoint1.transform.position, firepoint1.transform.rotation);
        GameObject rock1 = Instantiate(rocks, firepoint2.transform.position, firepoint2.transform.rotation);
        GameObject rock2 = Instantiate(rocks, firepoint3.transform.position, firepoint3.transform.rotation);
        GameObject rock3 = Instantiate(rocks, firepoint4.transform.position, firepoint4.transform.rotation);
        GameObject rock4 = Instantiate(rocks, firepoint5.transform.position, firepoint5.transform.rotation);
        GameObject rock5 = Instantiate(rocks, firepoint6.transform.position, firepoint6.transform.rotation);
        GameObject rock6 = Instantiate(rocks, firepoint7.transform.position, firepoint7.transform.rotation);
        GameObject rock7 = Instantiate(rocks, firepoint8.transform.position, firepoint8.transform.rotation);
        animator.SetBool("isAttacking", false);
    }
    void Mover() 
    {

    }
    IEnumerator Atacar() 
    {

        time += Time.deltaTime;
        for (int i = 0; i < 20; i++)
        {
            if (time > 0.8f)
            {

                GameObject rock = Instantiate(rocks, firepoitnA.transform.position, firepoitnA.transform.rotation);
                time = 0;
            }
        }
        yield return new WaitForSeconds(3);
    }
}
