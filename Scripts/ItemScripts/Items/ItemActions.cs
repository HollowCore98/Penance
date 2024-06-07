using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemActions : Items
{
    [Header("ReadableItems Variables")]
    [SerializeField]
    private TextAsset inkJson;

    [SerializeField]
    private GameObject textNamePanel;


    [Header("KeyItems Variables")]
    public ItemsData itemData;
    private string pickUp;
    [SerializeField] TextMeshProUGUI bottomText;
    private string pickedItemTag;

    [Header("Interactable Variables")]
    private bool obstacleTag;
    //[SerializeField] bool register;

     
        

    public void Awake()
    {
        SaveManager.Init();
    }
    public void ActionCall()
    {
        //if (itemType == ItemType.Key) KeyFunction();
        //if (itemType == ItemType.Interact) InteractFunction();
        //if (itemType == ItemType.Read) ReadFunction();
        //if (itemType == ItemType.Save) SaveFunction();
        itemType = ItemType.Read;
        itemType = ItemType.Key;
        itemType = ItemType.Interact;
    }

  
    public void KeyFunction(InputAction.CallbackContext context)
    {
       
        if (context.phase == InputActionPhase.Performed)
        {
            
            gameObject.SetActive(false);
            pickUp = ("You picked " + itemData.name);
            bottomText.text = pickUp;
            pickedItemTag = gameObject.tag;
            //InventoryScript.GetInventoryScript().InventoryWork();
            //register = true;
        }
    }

    public void InteractFunction(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
          
        }
    }

    public void ReadFunction(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed )
        {
            textNamePanel.SetActive(false);
            DialogueManager.GetDialogueManager().EnterReadMode(inkJson);
            DialogueManager.GetDialogueManager().ContinueStory();
        }
        if (context.phase == InputActionPhase.Performed)
        {
            textNamePanel.SetActive(true);
            DialogueManager.GetDialogueManager().ExitReadMode();
        }
    }
   
    void SaveFunction()
    {
   
       // if (Input.GetButtonDown("Fire1"))
       // {
          //  SaveObject saveObject = new SaveObject
          //  {
          // };
           // }Ite
    }

    private class SaveObject
    {
        public Vector3 playerPosition;
    }
}
