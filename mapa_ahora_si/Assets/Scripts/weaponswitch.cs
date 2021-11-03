using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponswitch : MonoBehaviour
{
    int totalWeapons = 0;
    public int currentWeaponIndex;
    public List<GameObject> guns=new List<GameObject>();
    public GameObject weaponholder;
    public GameObject currentGun;
    [SerializeField] private WeaponUi weaponUi;
    // Start is called before the first frame update
    void Start()
    {
       // totalWeapons = weaponholder.transform.childCount;
        //guns = new List<GameObject>();
        //for (int i = 0; i < totalWeapons; i++)
        //{
          //  guns.Add(weaponholder.transform.GetChild(i).gameObject);
            //guns[i].SetActive(false);

       // }
        //guns[0].SetActive(true);
        //currentGun = guns[0];
        //currentWeaponIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(currentWeaponIndex<totalWeapons-1)
            {
                guns[currentWeaponIndex].SetActive(false);
                currentWeaponIndex += 1;
                guns[currentWeaponIndex].SetActive(true);
                currentGun = guns[currentWeaponIndex];
                weaponUi.UpdateInfo(currentGun.gameObject.GetComponent<GunSystem>().WeaponIcon, currentGun.gameObject.GetComponent<GunSystem>().magazine);
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (currentWeaponIndex>0)
            {
                guns[currentWeaponIndex].SetActive(false);
                currentWeaponIndex -= 1;
                guns[currentWeaponIndex].SetActive(true);
                currentGun = guns[currentWeaponIndex];
                weaponUi.UpdateInfo(currentGun.gameObject.GetComponent<GunSystem>().WeaponIcon, currentGun.gameObject.GetComponent<GunSystem>().magazine);
            }
        }
        if (currentGun != null)
        {
            weaponUi.UpdateInfo(currentGun.gameObject.GetComponent<GunSystem>().WeaponIcon, currentGun.gameObject.GetComponent<GunSystem>().magazine);
        }
    }

    public void AddWeapon(GameObject weapon)
    {
        
        guns.Add(weapon);
        if (totalWeapons > 0) 
        {
            guns[currentWeaponIndex].SetActive(false);
        }
        guns[totalWeapons].SetActive(true);
        currentWeaponIndex = totalWeapons;
        currentGun = guns[currentWeaponIndex];
        totalWeapons++;
        weaponUi.UpdateInfo(currentGun.gameObject.GetComponent<GunSystem>().WeaponIcon, currentGun.gameObject.GetComponent<GunSystem>().magazine);
    }
}
