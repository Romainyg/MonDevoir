using UnityEngine;
using UnityEngine.UI;

public class HealthBarUI : MonoBehaviour
{
    public Slider healthSlider;

    [SerializeField] private GameManager gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
        GetComponent<Slider>().maxValue = gameManager.playerMaxHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (healthSlider.value != gameManager.playerHealth)
        {
            healthSlider.value = gameManager.playerHealth;
        }
    }
}
