using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerScript : MonoBehaviour
{
    // [SerializeField] private Animator drawerAnim;
    // [SerializeField] private string drawerOpen, drawerClose;
    //drawerAnim.Play(drawerOpen, 0, 0.0f);
    //drawerAnim.Play(drawerClose, 0, 0.0f);
    [SerializeField] private GameObject playerItem;
    private bool playerInside;

    private void Start()
    {
        playerInside = false;
    }

    private void Update()
    {

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (playerItem.CompareTag("DrawerKey"))
        {
            playerInside = true;
        }
    }

    public void Correcto()
    {
        Debug.Log("correcto");
    }






}
