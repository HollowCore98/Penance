using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PadlockSystemManager : MonoBehaviour
{
    public GameObject padlock;

    private PadlockMovement padlockMovement;

    public void Awake()
    {
        padlockMovement = padlock.GetComponent<PadlockMovement>();
    }

    // Cambio de escena 
    public void PadlockSceneLeave(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Performed) SceneManager.LoadScene("Preset");
    }
    
    public void DialMovement(InputAction.CallbackContext context)
    {
        
        if (context.phase == InputActionPhase.Performed) padlockMovement.DialMovement();
    }
    public void RotateDial(InputAction.CallbackContext context)
    {       
        if (context.phase == InputActionPhase.Performed) padlockMovement.RotateDial();
    }

}
