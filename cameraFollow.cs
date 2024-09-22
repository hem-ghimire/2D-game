using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public float smoothSpeed = 0.125f; // Adjust for smooth camera movement
    public Vector3 offset; // Adjust the camera position (e.g., above or behind the player)

    void LateUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // Smooth the transition
        transform.position = new Vector3(smoothedPosition.x, transform.position.y, transform.position.z); // Only move the camera horizontally
    }
}
