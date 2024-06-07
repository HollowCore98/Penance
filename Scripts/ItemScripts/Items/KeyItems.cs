using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeyItems : Items
{
    [Header("KeyItems Variables")]
    public ItemsData itemData;
    private string pickUp;
    [SerializeField] TextMeshProUGUI bottomText;
    private string pickedItemTag;

    public void ActionCall()
    {
        itemType = ItemType.Key;
    }
    public void KeyFunction(InputAction.CallbackContext context)
    {

        if (context.phase == InputActionPhase.Performed)
        {

            gameObject.SetActive(false);
            pickUp = ("You picked " + itemData.name);
            bottomText.text = pickUp;
            pickedItemTag = gameObject.tag;
        }
    }
   
}
