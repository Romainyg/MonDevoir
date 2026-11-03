using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ShopUI : MonoBehaviour
{
GameManager gameManager;

    private void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }


    public void OpenShop ()
    {
        GetComponent<Image>().enabled = true;
        if (GameManager.gameManager.gold >= gameManager.prix)
        {
            Debug.Log("pas");
            GetComponent<Image>().color = Color.green;
            GetComponent<Button>().enabled = true;
        }
        else
        {
            Debug.Log("pas les");
            GetComponent<Image>().color = Color.red;
        }
    }

    public void CloseShop()
    {
        GetComponent<Image>().enabled = false;
        GetComponent<Button>().enabled = false;
    }

    public void SeeGold()
    {
        if (GameManager.gameManager.gold >= gameManager.prix)
        {
            GetComponent<Image>().color = Color.green;
        }
        else
        {
            GetComponent<Image>().color = Color.red;
        }
    }

    public void Buy()
    {
        if(GameManager.gameManager.gold >= gameManager.prix)
        {
                    gameManager.playerMaxHealth += 10;
        gameManager.playerHealth += 10;
        gameManager.gold -= gameManager.prix;
        gameManager.prix += 50;
        }

    }
}
