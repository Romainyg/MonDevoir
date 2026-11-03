using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int gold = 0;

    public static GameManager gameManager;

    public int goldSave;

    public int numberOfLevel = -1;

    public int numberOfShoop = 1;

    public int playerHealth = 100;

    public int playerMaxHealth = 100;

    public string difficulte;

    public int numberOfDashes = 1;

    public int maxNumberOfDashes = 1;

    public int lastScene = 0;

    public int prix = 100;   

    private void Awake()
    {
        if (gameManager == null)
        {
            gameManager = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
            
    }
        
    public void AddGold(int amout)
    {
        gold += amout;
    }

    public void PlayerIsDead()
    {
            gold = 0;
        numberOfLevel = -1;  
    }

    public void saveGold()
    {
        goldSave = gold + goldSave;
        gold = 0;
        Debug.Log("gold save" + goldSave);
    }

    public void retraitGold()
    {
        gold = goldSave + gold;
        goldSave = 0;
        Debug.Log("retrait" + gold);
    }

    public void AddNomberOfLevel ()
    {
        if (numberOfLevel != -1)
        {
            numberOfLevel++;
            Debug.Log("numberOfLevel" + numberOfLevel);
        }
        
        if (numberOfLevel >= 5 && numberOfLevel < 10)
        {
            difficulte = "Moyen";
        }
        else if (numberOfLevel >= 10)
        {
            difficulte = "Dur";
        }
    }

    public void HealthCamp ()
    {
        playerHealth = playerMaxHealth;
        numberOfLevel = -1;
    }

    public void AddDash()
    {
        if (numberOfDashes < maxNumberOfDashes)
        {
            numberOfDashes += 1;
        }
    }

}
