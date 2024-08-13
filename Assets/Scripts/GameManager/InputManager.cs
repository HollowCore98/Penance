using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public GameObject player;
    public GameObject lighter;
   
    

    private PlayerRaycast playerRaycast;
    private PlayerMovement playerMovement;
    private OnMouseLook onMouseLook;
    private FlaslightBehavior flaslightBehavior;

    public void Awake()
    {
        playerRaycast = player.GetComponent<PlayerRaycast>();
        playerMovement = player.GetComponent<PlayerMovement>();
        onMouseLook = player.GetComponent<OnMouseLook>();
        flaslightBehavior = lighter.GetComponent<FlaslightBehavior>();
    }

    public void MovementAction(InputAction.CallbackContext context)
    {
        //Debug.Log(context.ReadValue<Vector2>());
        
        playerMovement.MovementAction(context.ReadValue<Vector2>());
    }

    public void RotationX(InputAction.CallbackContext context)
    {
        
        //Debug.Log(context.ReadValue<float>());
        onMouseLook.RotationX(context.ReadValue<float>());
    }
    public void RotationY(InputAction.CallbackContext context)
    {
        
        //Debug.Log(context.ReadValue<float>());
        onMouseLook.RotationY(context.ReadValue<float>());
    }

    public void _KeyItemInputs(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed) playerRaycast.KeyItemInputs();
    }
    public void _FlashlightOnOff(InputAction.CallbackContext context)
    {
        
        if (context.phase == InputActionPhase.Performed) flaslightBehavior.FlashlightOnOff();
    }
   
}
