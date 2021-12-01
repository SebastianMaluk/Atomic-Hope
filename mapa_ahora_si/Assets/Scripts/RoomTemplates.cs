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
    public GameObject[] Door;
    public GameObject[] Floor;

    public List<GameObject> rooms;
    public int roomcount;
    public int roomMax = 7;

    public GameObject Boss;
    public GameObject BasicEnemy;
    public GameObject BasicEnemy2;

    public int FloorCount = 0;
    public int FloorMax = 2;
    public int RandomFloor;

    private void Start()
    {
        Invoke("SpawnEnemies", 3f);
        Invoke("SpawnGuns", 3f);
        Invoke("SpawnKey", 3f);
        Invoke("SpawnDoor", 3f);
    }

    void SpawnEnemies()
    {
        Instantiate(Boss, rooms[rooms.Count - 1].transform.position, Quaternion.identity);
        for(int i =0; i<11; i++)
        {
            int r = Random.Range(3, 8);
            Vector3 pos = new Vector3(Random.Range(-8f, 8f), Random.Range(-8f, 8f), 0f);
            Instantiate(BasicEnemy, rooms[r].transform.position + pos, Quaternion.identity);
            Vector3 pos2 = new Vector3(Random.Range(-8f, 8f), Random.Range(-8f, 8f), 0f);
            Instantiate(BasicEnemy2, rooms[r].transform.position + pos, Quaternion.identity);
        }
    }
    void SpawnGuns() 
    {
        Vector3 pos0 = new Vector3(0f, -7f, 0f);
        Vector3 pos = new Vector3(Random.Range(-8f, 8f), Random.Range(-8f, 8f), 0f);
        Instantiate(guns[0], rooms[1].transform.position+pos0, Quaternion.identity);
        Instantiate(guns[1], rooms[Random.Range(2, 6)].transform.position+pos,Quaternion.identity);
    }
    void SpawnKey()
    {
        Vector3 pos = new Vector3(Random.Range(-8f, 8f), Random.Range(-8f, 8f), 0f);
        Instantiate(key, rooms[Random.Range(2, 10)].transform.position+pos, Quaternion.identity);
    }
    void SpawnDoor()
    {
        if (rooms[rooms.Count -1].name == "L(Clone)")
        {
            Vector3 posL = new Vector3(-10f, 0f, 0f);
            Instantiate(Door[0], rooms[rooms.Count - 1].transform.position+posL, Quaternion.identity);
        }
        if (rooms[rooms.Count - 1].name == "R(Clone)")
        {
            Vector3 posR = new Vector3(10f, 0f, 0f);
            Instantiate(Door[0], rooms[rooms.Count - 1].transform.position + posR, Quaternion.identity);
        }
        if (rooms[rooms.Count - 1].name == "T(Clone)")
        {
            Vector3 posT = new Vector3(0f, 10f, 0f);
            Instantiate(Door[1], rooms[rooms.Count - 1].transform.position + posT, Quaternion.identity);
        }
        if (rooms[rooms.Count - 1].name == "B(Clone)")
        {
            Vector3 posB = new Vector3(0f, -10f, 0f);
            Instantiate(Door[1], rooms[rooms.Count - 1].transform.position + posB, Quaternion.identity);
        }
    }

}
