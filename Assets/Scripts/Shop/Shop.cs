using UnityEngine;

public class Shop : MonoBehaviour
{
    ShopUI shopUI;

    ShopText shopText;

    AudioSource audioSource;

    ShopPrix shopPrix;

    private void Start()
    {
        shopText = FindFirstObjectByType<ShopText>();
        shopUI = FindFirstObjectByType<ShopUI>();
        shopPrix = FindFirstObjectByType<ShopPrix>();
        audioSource = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if ( other.gameObject.GetComponent<PlayerMouvement>())
        {
            shopText.OpenShopText();
            shopUI.OpenShop();
            audioSource.Play();
            shopPrix.OpenShopText();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerMouvement>())
        {
            shopText.CloseShopText();
            shopUI.CloseShop();
            shopPrix.CloseShopText();
        }
    }
}
