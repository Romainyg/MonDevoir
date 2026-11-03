using UnityEngine;
using UnityEngine.UI;

public class BossHealthUI : MonoBehaviour
{
    public Slider healthSlider;

    [SerializeField] private BossHealth bossHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bossHealth = FindFirstObjectByType<BossHealth>();
        GetComponent<Slider>().maxValue = bossHealth.maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (healthSlider.value != bossHealth.health)
        {
            healthSlider.value = bossHealth.health;
        }
    }
}