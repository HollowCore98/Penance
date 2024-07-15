using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject inventoryPanel;
    void Start()
    {
        
    }

    void Update()
    {
        OpenInventory();
    }

    void OpenInventory()
    {
       // if (Input.GetKeyDown(KeyCode.Tab))
       // {
          //  inventoryPanel.SetActive(!inventoryPanel.activeSelf);
        //}
    }

    void Load()
    {
        string saveString = SaveManager.Load();
        if (saveString != null)
        {
            SaveObject saveObject = JsonUtility.FromJson<SaveObject>(saveString);
            transform.position = saveObject.playerPosition;
        }
    }

    private class SaveObject
    {
        public Vector3 playerPosition;
    }
}
