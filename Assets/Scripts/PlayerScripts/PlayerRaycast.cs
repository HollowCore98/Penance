using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    public ItemActions itemActions;

    [SerializeField] LayerMask itemLayer;
    [SerializeField] float rayDistance;
    
    Ray ray;
    RaycastHit hit;
    Transform myCamera;

    private void Start()
    {
        myCamera = Camera.main.transform;
    }
    
    private void Update()
    {
        ray.origin = myCamera.position;
        ray.direction = myCamera.forward;
        
        if(Physics.Raycast(ray, out hit, rayDistance, itemLayer))
        {
            itemActions = hit.collider.GetComponent<ItemActions>();
            if(itemActions != null)
            {
                itemActions.IsObjectSelected(true);     
            }
        }
        else
        {
            if(itemActions != null)
            {
                itemActions.IsObjectSelected(false);
                itemActions = null;
            }
        }

    }
    public void KeyItemInputs()
    {
        if (itemActions !=null) itemActions.ActionCall();
    }

}
