using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUi : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Image icon;

    public void UpdateInfo(Sprite keyIcon)
    {
        icon.color = Color.white;
        icon.sprite = keyIcon;
    }
}
