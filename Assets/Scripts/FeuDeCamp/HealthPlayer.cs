using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    GameManager gameManager;
    [SerializeField] private PlayerDash playerDash;
    [SerializeField]  GameObject DashUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
        gameManager.HealthCamp();
    }

    // Update is called once per frame
    void Update()
    {
        gameManager.numberOfDashes = playerDash.maxNumberOfDashes;
    }
}
