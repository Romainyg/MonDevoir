using TMPro;
using UnityEngine;

public class ShopPrix : MonoBehaviour
{
    GameManager gameManager;

    private void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
 
    }

    void FixedUpdate()
    {


        GetComponent<TextMeshProUGUI>().text = gameManager.prix.ToString();
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
