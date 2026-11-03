using TMPro;
using UnityEngine;

public class NumberOfLevels : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    string numberOfLevelsText;

    void Start()
    {
        gameManager = GameManager.gameManager;
        numberOfLevelsText = gameManager.numberOfLevel.ToString();
        TextMeshProUGUI textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = numberOfLevelsText;
    }
    void FixedUpdate()
    {
        numberOfLevelsText = gameManager.numberOfLevel.ToString();
        TextMeshProUGUI textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = numberOfLevelsText;
    }
}
