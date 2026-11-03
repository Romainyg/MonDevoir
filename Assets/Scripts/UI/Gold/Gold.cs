using TMPro;
using UnityEngine;

public class Gold : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    string goldText;

    void Start()
    {
        gameManager = GameManager.gameManager;
        goldText = gameManager.gold.ToString();
        TextMeshProUGUI textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = goldText;
    }
    void FixedUpdate()
    {
        goldText = gameManager.gold.ToString();
        TextMeshProUGUI textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = goldText;
    }
}
