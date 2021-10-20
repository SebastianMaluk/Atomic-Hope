using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndShoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private Vector3 target;
    public float distance;
    public GameObject weapon;
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        distance = 5f;
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direccion = target - player.transform.position;
        direccion.Normalize();
        transform.position =player.transform.position+(direccion * distance);
        float rotation = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Rad2Deg;
        weapon.transform.rotation = Quaternion.Euler(0f, 0f, rotation);
        weapon.transform.position = player.transform.position + direccion;
        

    }
}
