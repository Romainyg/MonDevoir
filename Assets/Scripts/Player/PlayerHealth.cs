using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    PlayerDead playerDead;

    GameManager gameManager;

    private void Start()
    {
        playerDead = GetComponent<PlayerDead>();
        gameManager = FindFirstObjectByType<GameManager>();
    }

    public void TakeDamage (int damage)
    {
        gameManager.playerHealth -= damage;
        if (gameManager.playerHealth <= 0)
        {
            playerDead.PlayerIsDead();
        }
    }
}
