using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryScript : MonoBehaviour
{
    private static InventoryScript inventoryScript;

    public ItemsData itemData;
    private string keyItemList;
    [SerializeField] TextMeshProUGUI keyListSlot;

    private void Awake()
    {
        inventoryScript = this;
    }

    public static InventoryScript GetInventoryScript()
    {
        return inventoryScript;
    }

    public void InventoryWork()
    {
        Debug.Log("hasta aqui va bien el inventario");
        if(itemData == null) return;
        keyItemList = itemData.name;
        keyListSlot.text = keyItemList;
    }
}
