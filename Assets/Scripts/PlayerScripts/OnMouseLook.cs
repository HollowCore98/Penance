using UnityEngine.InputSystem;
using UnityEngine;

public class OnMouseLook : MonoBehaviour
{

    #region Serialize_variables
    [Header("Mouse Look")]
    [SerializeField] float mouseSensitivity;
    [SerializeField] float bottomAngle;
    [SerializeField] float topAngle;
    [SerializeField] float yRotationSpeed;
    [SerializeField] float xCameraSpeed;
    #endregion

    #region private_variables
    private float desiredYRotation;
    private float desiredCameraXRotation;
    private float currentYRotation;
    private float currentCameraxRotation;
    private float rotationYVelocity;
    private float cameraXVelocity;
    private float direction;
    #endregion

    private Camera myCamera;
    private float mouseX;
    private float mouseY;

    void Awake()
    {
        myCamera = Camera.main;
        //bloquear el cursor
        Cursor.lockState = CursorLockMode.Locked;
        desiredYRotation = currentYRotation = transform.rotation.eulerAngles.y;
        desiredCameraXRotation = currentCameraxRotation = myCamera.transform.localRotation.x;
    }
    private void FixedUpdate()
    {
        ApllyRotation();
    }
    public void RotationX(float _mouseX)
    {
        mouseX = _mouseX;
        //Debug.Log(context.ReadValue<float>());
    }
    public void RotationY(float _mouseY)
    {
        mouseY = _mouseY;
        //Debug.Log(context.ReadValue<float>());
    }
    void ApllyRotation()
    {
        //giro que quiero para el player entorno al eje Y
        desiredYRotation = desiredYRotation + (mouseX * mouseSensitivity);
        //giro que quiero para la camara en torno al eje x
        desiredCameraXRotation = desiredCameraXRotation - (mouseY * mouseSensitivity);
        //limitamos el valor de los ángulos
        desiredCameraXRotation = Mathf.Clamp(desiredCameraXRotation, bottomAngle, topAngle);
        // Con "Mathf.Clamp" limitamos una variable entre un "valor minimo y uno máximo"

        currentYRotation = Mathf.SmoothDamp(currentYRotation, desiredYRotation, ref rotationYVelocity,
        yRotationSpeed);
        currentCameraxRotation = Mathf.SmoothDamp(currentCameraxRotation, desiredCameraXRotation,
            ref cameraXVelocity, xCameraSpeed);

        //Aplicamos la rotacion al Gameobject
        //giro a lo larho del eje y
        transform.rotation = Quaternion.Euler(0, currentYRotation, 0);
        //giro la camara a lo largo del eje X
        myCamera.transform.localRotation = Quaternion.Euler(currentCameraxRotation, 0, 0);
    }
}
