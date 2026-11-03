using UnityEngine;

public class RetraitGold : MonoBehaviour
{
    GameManager gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerMouvement>())
        {
            gameManager.retraitGold();
        }
    }
}
