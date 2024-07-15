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

    public void FlashlightOnOff()
    {
        if (flashlightWorking)
        {
            //obtenemos el estado del componente (la linterna) y lo cambiamos
            spotLight.enabled = !spotLight.enabled;
        }
    }

}
