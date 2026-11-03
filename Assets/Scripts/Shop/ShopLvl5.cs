using UnityEngine;

public class ShopLvl5 : MonoBehaviour
{
    GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
        gameManager.numberOfShoop++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
