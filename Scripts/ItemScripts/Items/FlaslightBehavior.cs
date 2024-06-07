using UnityEngine.InputSystem;
using UnityEngine;

public class FlaslightBehavior : MonoBehaviour
{
    private Light spotLight;
    private bool flashlightWorking;

    public OnMouseLook OnMouseLook
    {
        get => default;
        set
        {
        }
    }

    private void Awake()
    {
        spotLight = GetComponent<Light>();
        flashlightWorking = true;
    }

    public void FlashlightOnOff(InputAction.CallbackContext context)
    {
        Debug.Log(context.phase);
        if (context.phase == InputActionPhase.Performed && flashlightWorking)
        {
            //obtenemos el estado del componente (la linterna) y lo cambiamos
            spotLight.enabled = !spotLight.enabled;
        }
    }

}
