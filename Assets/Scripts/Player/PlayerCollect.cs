using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    int TargetGold = 10;
    int RareTargetGold = 20;

    public GameManager gameManager;


    private void Awake()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Target>())
        {
            gameManager.AddGold(TargetGold);
            Destroy(other.gameObject);
        }
        else if (other.gameObject.GetComponent<RareTarget>())
        {
            gameManager.AddGold(RareTargetGold);
            Destroy(other.gameObject);
        }
        else if (other.gameObject.GetComponent<Dash>())
        {
            if (gameManager.numberOfDashes < gameManager.maxNumberOfDashes)
            {
                gameManager.AddDash();
                Destroy(other.gameObject);
            }
        }
    }
}
