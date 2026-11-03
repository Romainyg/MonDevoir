using TMPro;
using UnityEngine;

public class ShopText : MonoBehaviour
{
    GameManager gameManager;

    private void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }

 
    public void OpenShopText()
    {
        GetComponent<TMP_Text>().enabled = true;
    }

    public void CloseShopText ()
    {
        GetComponent<TMP_Text>().enabled = false;
    }
}
