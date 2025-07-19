using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjustable speed in the Inspector
    private Rigidbody2D rb; // Optional: for physics-based movement

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Optional: get the Rigidbody2D component
    }

    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal"); // A/D or Left/Right arrow
        float verticalInput = Input.GetAxisRaw("Vertical");   // W/S or Up/Down arrow

        Vector2 movement = new Vector2(horizontalInput, verticalInput).normalized;

        // For direct transform manipulation
        //transform.Translate(movement * moveSpeed * Time.deltaTime);

        // Or for Rigidbody2D (use in FixedUpdate for physics consistency)
        rb.linearVelocity = movement * moveSpeed;
    }
}
