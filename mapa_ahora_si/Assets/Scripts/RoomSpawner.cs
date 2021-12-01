using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{

    public int openSide;
    private int rand;
    private bool spawner = false;
    private int randfloor;

    private RoomTemplates templates;
    

    void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();

        
        Invoke("Spawn", 0.1f);
        
        
    }

    void Spawn()
    {

        if (spawner == false)
        {
            if (templates.roomcount < templates.roomMax)
            {

                if (templates.FloorCount > templates.FloorMax)
                {
                    templates.FloorCount = 0;
                }

                if (templates.FloorCount == 0)
                {
                    randfloor = Random.Range(0, templates.Floor.Length);
                    templates.RandomFloor = randfloor;
                    templates.FloorCount += 1;

                }
                randfloor = Random.Range(0, templates.Floor.Length);


                if (openSide == 1)//b
                {
                    rand = Random.Range(0, templates.bottomRooms.Length);
                    Instantiate(templates.Floor[randfloor], transform.position, templates.Floor[randfloor].transform.rotation);
                    Instantiate(templates.bottomRooms[rand], transform.position, templates.bottomRooms[rand].transform.rotation);
                }
                else if (openSide == 2)//t
                {
                    rand = Random.Range(0, templates.topRooms.Length);
                    Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation);

                    Instantiate(templates.Floor[randfloor], transform.position, templates.Floor[randfloor].transform.rotation);
                }
                else if (openSide == 3) //left
                {
                    rand = Random.Range(0, templates.leftRooms.Length);
                    Instantiate(templates.leftRooms[rand], transform.position, templates.leftRooms[rand].transform.rotation);

                    Instantiate(templates.Floor[randfloor], transform.position, templates.Floor[randfloor].transform.rotation);
                }
                else if (openSide == 4)//r
                {
                    rand = Random.Range(0, templates.rightRooms.Length);
                    Instantiate(templates.rightRooms[rand], transform.position, templates.rightRooms[rand].transform.rotation);

                    Instantiate(templates.Floor[randfloor], transform.position, templates.Floor[randfloor].transform.rotation);
                }
                templates.roomcount += 1;
                spawner = true;
            }
            else
            {
                if (openSide == 1)//b
                {
                    rand = Random.Range(0, templates.bottomEnd.Length);
                    Instantiate(templates.bottomEnd[rand], transform.position, templates.bottomEnd[rand].transform.rotation);

                    Instantiate(templates.Floor[randfloor], transform.position, templates.Floor[randfloor].transform.rotation);
                }
                else if (openSide == 2)//t
                {
                    rand = Random.Range(0, templates.topEnd.Length);
                    Instantiate(templates.topEnd[rand], transform.position, templates.topEnd[rand].transform.rotation);

                    Instantiate(templates.Floor[randfloor], transform.position, templates.Floor[randfloor].transform.rotation);
                }
                else if (openSide == 3) //left
                {
                    rand = Random.Range(0, templates.leftEnd.Length);
                    Instantiate(templates.leftEnd[rand], transform.position, templates.leftEnd[rand].transform.rotation);

                    Instantiate(templates.Floor[randfloor], transform.position, templates.Floor[randfloor].transform.rotation);
                }
                else if (openSide == 4)//r
                {
                    rand = Random.Range(0, templates.rightEnd.Length);
                    Instantiate(templates.rightEnd[rand], transform.position, templates.rightEnd[rand].transform.rotation);

                    Instantiate(templates.Floor[randfloor], transform.position, templates.Floor[randfloor].transform.rotation);
                    //Instantiate(templates.Floor[templates.RandomFloor], transform.position, templates.Floor[templates.RandomFloor].transform.rotation);
                }

                spawner = true;
            }


        }

    }









    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SpawnPoint"))
        {
             if (collision.GetComponent<RoomSpawner>().spawner == false && spawner == false)
             {
                Instantiate(templates.closedRoom, transform.position, Quaternion.identity);
                Destroy(gameObject);
             }
            spawner = true;
            
        }
    }


}
