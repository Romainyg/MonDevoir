using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public float health = 10000;
    public int maxHealth = 10000;
    public GameManager gameManager;
    private void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }

    private void FixedUpdate()
    {
        TakeDamage();
    }
   
    public void TakeDamage()
    {
        health -= 0.2f;
        if (health <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        gameManager.AddGold(50);
        Destroy(gameObject);
    }
}
