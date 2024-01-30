using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 50; // Example health value

    public void TakeDamage(int damage) {
        health -= damage;
        if (health <= 0) {
            Destroy(gameObject); // Destroy enemy when health is 0 or less
        }
    }
}
