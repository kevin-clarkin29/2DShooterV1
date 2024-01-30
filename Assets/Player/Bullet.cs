using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 10; // Example damage value

    void OnCollisionEnter2D(Collision2D collision) {
        
        
        
        // Check if the collided object has an "Enemy" tag
        if (collision.gameObject.CompareTag("Enemy")) {
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();
            if (enemy != null) {
                enemy.TakeDamage(damage);
            }
        }
        
        Destroy(gameObject); // Destroy the bullet whether it hits an enemy or not

        // need to create code to destroy the bullet after 3 seconds so as to free up resources
    }
}
