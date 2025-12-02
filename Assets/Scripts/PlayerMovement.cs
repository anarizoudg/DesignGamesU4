using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float boostedSpeed = 10f;  // velocidad durante el boost
    private float currentSpeed;

    public float jumpForce = 6f;
    private Rigidbody rb;

    private bool isGrounded = true;
    private bool isBoosting = false;
    private float boostTimer = 0f;
    public float boostDuration = 3f; // duración máxima

    // Referencia a la barra del boost
    public BoostBar boostBar;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentSpeed = speed;

        if (boostBar != null)
            boostBar.SetMaxTime(boostDuration);
    }

    void Update()
    {
        // Si está en boost, reducir el tiempo
        if (isBoosting)
        {
            boostTimer -= Time.deltaTime;
            boostBar.SetTime(boostTimer);

            if (boostTimer <= 0)
                EndBoost();
        }

        // Leer movimiento
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX * currentSpeed, rb.linearVelocity.y, moveZ * currentSpeed);
        rb.linearVelocity = movement;

        // Salto
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = true;
    }

    // 🔥 MÉTODO PÚBLICO PARA ACTIVAR EL BOOST
    public void ActivateBoost()
    {
        isBoosting = true;
        boostTimer = boostDuration;
        currentSpeed = boostedSpeed;

        if (boostBar != null)
            boostBar.ShowBar();
    }

    // 🔥 Terminar boost
    void EndBoost()
    {
        isBoosting = false;
        currentSpeed = speed;

        if (boostBar != null)
            boostBar.HideBar();
    }
}