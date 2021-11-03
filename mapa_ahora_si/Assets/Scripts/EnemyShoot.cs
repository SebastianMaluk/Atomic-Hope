using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{

    public GameObject player;
    private float time = 0f;
    public float shootrate;
    public GameObject bullet;
    public GameObject firepoint;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Jugador");
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Vector3 diff = player.transform.position - transform.position;
        diff.Normalize();

        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);

        float Dist = Vector3.Distance(player.transform.position, transform.position);
        if (Dist <= 10f && time >= shootrate)
        {
            Shoot();
            time = 0;
        }
    }

    public void Shoot()
    {
        GameObject rock = Instantiate(bullet, firepoint.transform.position, firepoint.transform.rotation);
    }
}
