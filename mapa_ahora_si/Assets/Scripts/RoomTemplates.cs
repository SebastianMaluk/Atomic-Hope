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

    public List<GameObject> rooms;
    public int roomcount;
    public int roomMax = 7;

    public GameObject Boss;
    public GameObject BasicEnemy;

    private void Start()
    {
        Invoke("SpawnEnemies", 3f);
    }

    void SpawnEnemies()
    {
        Instantiate(Boss, rooms[rooms.Count - 1].transform.position, Quaternion.identity);
    }

}
