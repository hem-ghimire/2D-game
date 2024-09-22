using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    public Transform player;
    public float parallaxFactor;

    private Vector3 previousPlayerPosition;

    void Start()
    {
        previousPlayerPosition = player.position;
    }

    void Update()
    {
        Vector3 deltaMovement = player.position - previousPlayerPosition;
        transform.position += new Vector3(deltaMovement.x * parallaxFactor, 0, 0);
        previousPlayerPosition = player.position;
    }
}
