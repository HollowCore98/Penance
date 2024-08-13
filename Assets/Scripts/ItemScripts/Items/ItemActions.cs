using UnityEngine.InputSystem;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ItemActions : Items
{
    DrawerScript drawerScript;


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
    [SerializeField] private GameObject sceneItem;
    [SerializeField] private GameObject playerItem;
    


    [Header("Door variables")]
    private Animator anim;
    [SerializeField] private string doorOpen, doorClose;
    private float time = 4;
   
    private NewInputs inputs;
    
    public void Awake()
    {
        SaveManager.Init();
        anim = GetComponent<Animator>();
        inputs = new NewInputs();
        drawerScript = GetComponent<DrawerScript>();
    }
    
    public void ActionCall()
    {
        if (itemType == ItemType.Key) KeyFunction();
        if (itemType == ItemType.Interact) InteractFunction();
        if (itemType == ItemType.Read) ReadFunction();
        if (itemType == ItemType.Door) StartCoroutine(nameof(DoorFunction));
        if (itemType == ItemType.Padlock) PadlockSceneChange();
    }

    // items para interactuar
    public void KeyFunction()
    {
        gameObject.SetActive(false);
        sceneItem.SetActive(false);
        playerItem.SetActive(true);
        
        pickUp = ("You picked " + itemData.name);
        bottomText.text = pickUp;
        pickedItemTag = gameObject.tag;
        
        
    }

    public void InteractFunction()
    {
        
    }

    // puertas 
    IEnumerator DoorFunction()
    {

        // Abrir la puerta con el click del ratón

        if (anim.GetCurrentAnimatorStateInfo(0).IsName(doorClose))
        {
            anim.ResetTrigger("Close");
            anim.SetTrigger("Open");        
        }
        yield return new WaitForSeconds(time);
        if (anim.GetCurrentAnimatorStateInfo(0).IsName(doorOpen))
        {
            anim.ResetTrigger("Open");
            anim.SetTrigger("Close");
        }


    }

    //Padlock Scene Change

    public void PadlockSceneChange()
    {
        SceneManager.LoadScene("PadlockScene");
    }

    // items para leer
    public void ReadFunction()
    {
        if(textNamePanel.activeInHierarchy == true)
        {
            textNamePanel.SetActive(false);
            DialogueManager.GetDialogueManager().EnterReadMode(inkJson);
            DialogueManager.GetDialogueManager().ContinueStory();
        }
        else 
        {
            textNamePanel.SetActive(true);
            DialogueManager.GetDialogueManager().ExitReadMode();
        }

    }

    // guardado de datos
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(("Player")))
        {
            
            SaveFunction();
        }
    }
    void SaveFunction()
    {
      
        SaveObject saveObject = new SaveObject
        {

            playerPosition = transform.position,
            playerRotation = transform.eulerAngles
        };
        string json = JsonUtility.ToJson(saveObject);
        SaveManager.Save(json);
    }

    private class SaveObject
    {
        public Vector3 playerPosition;
        public Vector3 playerRotation;
    }
}
