using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponUi : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Image icon;
    [SerializeField] private Text magazinetext;

    public void UpdateInfo(Sprite weaponIcon, int magazine) 
    {
        icon.color = Color.white;
        icon.sprite = weaponIcon;
        magazinetext.text = magazine.ToString();
    }
}
