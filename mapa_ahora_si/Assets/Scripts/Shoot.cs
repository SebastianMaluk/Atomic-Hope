using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletprefab;
    public Transform firePoint;
    public int BulletCount=20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && BulletCount>0)
        {
            Disparar();
        }
    }

    void Disparar()
    {
        GameObject bullet = Instantiate(bulletprefab, firePoint.position, firePoint.rotation);
        BulletCount -= 1;
    }
}
