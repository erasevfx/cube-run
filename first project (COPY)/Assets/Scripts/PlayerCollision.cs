using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    
    public PlayerMovement movement;
    public Ground ground;

    void OnCollisionEnter (Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

        if (collisionInfo.collider.tag = "lvl5ground")
        {
            public bool isGrounded = true;
        }
    }

}
