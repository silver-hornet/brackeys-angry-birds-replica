using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float health = 4f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.magnitude > health)
            Die();
    }

    void Die()
    {
        Destroy(gameObject);
    }
}