using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of the player
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Horizontal movement
        movement.x = Input.GetAxisRaw("Horizontal"); // Gets -1 (left) to 1 (right) from input
    }

  void FixedUpdate()
{
    Vector2 newPosition = rb.position + movement * moveSpeed * Time.fixedDeltaTime;
    
    // Restrict player's movement to stay within the screen's left and right bounds
    newPosition.x = Mathf.Clamp(newPosition.x, Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + 0.5f, Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - 0.5f);
    
    rb.MovePosition(newPosition);
}
}
