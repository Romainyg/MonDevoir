using UnityEngine;

public class Buy : MonoBehaviour
{
    GameManager gameManager;

    ShopUI shopUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
        shopUI = FindFirstObjectByType<ShopUI>();
        gameManager.gold -= gameManager.prix;
        Debug.Log(gameManager.gold);
        shopUI.SeeGold();
    }
}
