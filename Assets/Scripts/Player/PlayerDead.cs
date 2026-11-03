using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDead : MonoBehaviour
{
    public GameManager gameManager;

    PlayerHealth playerHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
       playerHealth = GetComponent<PlayerHealth>();
    }

 
    public void PlayerIsDead()
    {
        gameManager = FindFirstObjectByType<GameManager>();
        gameManager.PlayerIsDead();
        SceneManager.LoadScene("DeathMenu");
    }

}
