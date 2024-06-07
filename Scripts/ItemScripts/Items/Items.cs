using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Items : MonoBehaviour
{
    public enum ItemType { Key, Read, Interact, Save};
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
