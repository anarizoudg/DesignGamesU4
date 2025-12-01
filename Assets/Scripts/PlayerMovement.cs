using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;       // velocidad en X y Z
    public float jumpForce = 6f;   // fuerza de salto en Y
    private Rigidbody rb;

    private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Movimiento horizontal (X) e inclinación (Z)
        float moveX = Input.GetAxis("Horizontal"); // A / D o flechas ← →
        float moveZ = Input.GetAxis("Vertical");   // W / S o flechas ↑ ↓

        // Crear el vector de movimiento
        Vector3 movement = new Vector3(moveX * speed, rb.linearVelocity.y, moveZ * speed);

        // Aplicar movimiento
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
        // Detectar si tocó el piso
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = true;
    }
}
