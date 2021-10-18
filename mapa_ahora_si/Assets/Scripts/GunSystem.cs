using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public int magazine;
    public float ratefire;
    public bool holdbutton;
    private float time=0f;

    public Transform firepoint;
    public GameObject Ammoprefab;

    
    // Update is called once per frame
    void Update()
    {
        
        if(holdbutton) 
        {

            if(Input.GetKey(KeyCode.Mouse0) && magazine > 0)
            {
                time += Time.deltaTime;
                if (time >= ratefire)
                {
                    Disparar();
                    time -= ratefire;
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Mouse0) && magazine > 0)
            {
                Disparar();
            }
        }
    }
    void Disparar()
    {
        GameObject bullet = Instantiate(Ammoprefab, firepoint.position, firepoint.rotation);
        magazine--;
    }
}
