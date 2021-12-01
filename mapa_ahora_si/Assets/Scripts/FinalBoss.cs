using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalBoss : MonoBehaviour
{
    private float latestDirectionChangeTime;
    private readonly float directionChangeTime = 3f;
    private float characterVelocity = 2f;
    private Vector2 movementDirection;
    private Vector2 movementPerSecond;
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
    public float start_time;
    public float end_time;
    public GameOverScreen GameOverScreen;
 
    void Start()
    {
        player = GameObject.Find("Jugador");
        canvas = GameObject.Find("Canvasenemy");
        text = GameObject.Find("Bossvida").GetComponent<Text>();
       
        canvas.SetActive(false);
        start_time = 0f;
        latestDirectionChangeTime = 0f;
        calcuateNewMovementVector();
    }
 
    void calcuateNewMovementVector()
    {
        //create a random direction vector with the magnitude of 1, later multiply it with the velocity of the enemy
        movementDirection = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)).normalized;
        movementPerSecond = movementDirection * characterVelocity;
    }
 
    void Update()
    {
        //if the changeTime was reached, calculate a new movement vector
        if (Time.time - latestDirectionChangeTime > directionChangeTime)
        {
            latestDirectionChangeTime = Time.time;
            calcuateNewMovementVector();
        }
        
        //move enemy: 
        transform.position = new Vector2(transform.position.x + (movementPerSecond.x * Time.deltaTime), 
        transform.position.y + (movementPerSecond.y * Time.deltaTime));
    }
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
        end_time += Time.deltaTime;
        if (vida <= 0)
        {
            Debug.Log("You Win");
            PlayerPrefs.SetFloat("TimePrefsName", end_time);
            Debug.Log(end_time);
            GameOverScreen.Setup();
            
            //Destroy(this.gameObject);
            //UnityEditor.EditorApplication.isPlaying = false;

        }
    }
    void Rocks()
        {
        GameObject rock = Instantiate(rocks, firepoint.transform.position,firepoint.transform.rotation);
        }
}
