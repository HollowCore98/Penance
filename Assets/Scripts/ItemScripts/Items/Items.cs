using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Items : MonoBehaviour
{
    
    public enum ItemType : int 
    { 
        None = 0,
        Key = 1, 
        Read = 2,
        Interact = 3, 
        Door = 4,
        Padlock = 5
    };
    public ItemType itemType;
    public Rigidbody rb;
    public new Collider collider;

    [SerializeField] string textToShow;
    [SerializeField] TextMeshProUGUI textUI;
    [SerializeField] Renderer rend;

    public void IsObjectSelected(bool selected)
    {
        if (selected)
        {
            textUI.text = textToShow;
        }
        else
        {
            textUI.text = "";
        }
    }
}
