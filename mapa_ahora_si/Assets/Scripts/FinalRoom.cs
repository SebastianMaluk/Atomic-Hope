using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalRoom : MonoBehaviour
{

    public GameObject[] guns;
    public GameObject[] Ammo;



    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnGuns", 2f);
        Invoke("SpawnAmmo", 2f);
    }


    void SpawnGuns()
    {
        Vector3 pos5 = new Vector3(2f, 4f, 0f);
        Vector3 pos6 = new Vector3(0f, 4f, 0f);
        Vector3 pos7 = new Vector3(-2f, 4f, 0f);
        Instantiate(guns[0], pos5, Quaternion.identity);
        Instantiate(guns[1], pos6, Quaternion.identity);
        Instantiate(guns[2], pos7, Quaternion.identity);
    }

    void SpawnAmmo()
    {
        Vector3 pos5 = new Vector3(2f, 5f, 0f);
        Vector3 pos6 = new Vector3(0f, 5f, 0f);
        Vector3 pos7 = new Vector3(-2f, 5f, 0f);
        Vector3 pos8 = new Vector3(2f, 6f, 0f);
        Vector3 pos9 = new Vector3(0f, 6f, 0f);
        Vector3 pos10 = new Vector3(-2f, 6f, 0f);
        Instantiate(Ammo[0], pos5, Quaternion.identity);
        Instantiate(Ammo[1], pos6, Quaternion.identity);
        Instantiate(Ammo[2], pos7, Quaternion.identity);
        Instantiate(Ammo[0], pos8, Quaternion.identity);
        Instantiate(Ammo[1], pos9, Quaternion.identity);
        Instantiate(Ammo[2], pos10, Quaternion.identity);
    }
}