using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    #region Public_Variables
    [Header("Movement")]
    [SerializeField] float accelerationSpeed;
    [SerializeField] float deccelerationSpeed;
    [SerializeField] int maxSpeed;

    #endregion

    Vector2 horizontalMovement,
            direction;
    Vector3 slowdown;

    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        Movement();
    }
    public void MovementAction(Vector2 _direction)
    {
        //Debug.Log(context.ReadValue<Vector2>());
        direction = _direction;
    }

    public void Movement()
    {

        //para controlar que no supere la velocidad máxima primero guardamos la velocidad en el RB.
        horizontalMovement = new Vector2(rb.velocity.x, rb.velocity.z);
        if (horizontalMovement.magnitude > maxSpeed)
        {
            // ahora limitamos la velocidad de movimiento (normalizamos y dps multiplicamos por maxSpeed).
            horizontalMovement = horizontalMovement.normalized;
            horizontalMovement = horizontalMovement * maxSpeed;
        }
        //por ultimos igualamos la velocidad del RB a la velocida calculada.
        rb.velocity = new Vector3(horizontalMovement.x, rb.velocity.y, horizontalMovement.y);

        rb.AddRelativeForce(direction.x * accelerationSpeed * Time.deltaTime, 0, direction.y * accelerationSpeed * Time.deltaTime);
        // eje x, eje y(0), eje z respectivamente.

        //desacceleramos el RB.
        rb.velocity = Vector3.SmoothDamp(rb.velocity, new Vector3(0, rb.velocity.y, 0),
            ref slowdown, deccelerationSpeed);
    }

}
