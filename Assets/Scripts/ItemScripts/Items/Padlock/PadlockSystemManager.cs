using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PadlockSystemManager : MonoBehaviour
{
    public GameObject padlock;
    
    public void PadlockSceneLeave(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Performed) SceneManager.LoadScene("Preset");
    }
    

}
