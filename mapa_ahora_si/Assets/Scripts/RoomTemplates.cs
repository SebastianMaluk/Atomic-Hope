using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTemplates : MonoBehaviour
{
    public GameObject[] bottomRooms;
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;
    public GameObject[] topEnd;
    public GameObject[] bottomEnd;
    public GameObject[] leftEnd;
    public GameObject[] rightEnd;
    public GameObject closedRoom;
    public GameObject[] guns;
    public GameObject key;

    public List<GameObject> rooms;
    public int roomcount;
    public int roomMax = 7;

    public GameObject Boss;
    public GameObject BasicEnemy;

    private void Start()
    {
        Invoke("SpawnEnemies", 3f);
        Invoke("SpawnGuns", 3f);
        Invoke("SpawnKey", 3f);
    }

    void SpawnEnemies()
    {
        Instantiate(Boss, rooms[rooms.Count - 1].transform.position, Quaternion.identity);
    }
    void SpawnGuns() 
    {
        Vector3 pos = new Vector3(Random.Range(-8f, 8f), Random.Range(-8f, 8f), 0f);
        Instantiate(guns[0], rooms[1].transform.position, Quaternion.identity);
        Instantiate(guns[1], rooms[Random.Range(2, 6)].transform.position+pos,Quaternion.identity);
    }
    void SpawnKey()
    {
        Vector3 pos = new Vector3(Random.Range(-8f, 8f), Random.Range(-8f, 8f), 0f);
        Instantiate(key, rooms[Random.Range(2, 10)].transform.position+pos, Quaternion.identity);
    }

}
