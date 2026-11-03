using UnityEngine;

public class StockGold : MonoBehaviour
{
    AudioSource audioSource;
    
    GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerMouvement>())
        {
            gameManager = FindAnyObjectByType<GameManager>();
            Debug.Log(gameManager.gold);
            if (gameManager.gold > 0)
            {
                audioSource.Play();
                gameManager.saveGold();
            }
        }
    }
}
