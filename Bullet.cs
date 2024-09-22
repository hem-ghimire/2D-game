using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.CompareTag("Enemy"))
        {
            Destroy(hitInfo.gameObject); // Destroy enemy
            Destroy(gameObject); // Destroy the bullet
        }
    }

    void Update()
    {
        // Destroy bullet after 2 seconds if no collision
        Destroy(gameObject, 2f);
    }
}
