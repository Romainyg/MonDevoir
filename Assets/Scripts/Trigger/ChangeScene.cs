using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    int RandomScene;

    int minScene = 1;

    int maxScene = 5;

    GameManager gameManager;

    private void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerMouvement>())
        {
            if(gameManager.numberOfLevel == -1)
            {
                gameManager.goldSave += gameManager.gold;
                gameManager.gold = 0;
                gameManager.numberOfLevel = 0;
            }
            gameManager.AddNomberOfLevel();
            if (gameManager.numberOfLevel == 15)
            {
                SceneManager.LoadScene("LastLevel");
            }
            else if (gameManager.numberOfLevel == 14)
            {
                SceneManager.LoadScene("BossLevel");
            }
            else if (gameManager.numberOfLevel % 5 == 0)
            {
                SceneManager.LoadScene("Shoop");

            }

            else
            {
                RandomScene = Random.Range(minScene, maxScene);
                if (RandomScene == gameManager.lastScene)
                {
                    RandomScene = Random.Range(minScene, maxScene);
                }
                SceneManager.LoadScene("Level" + RandomScene + gameManager.difficulte);
                gameManager.lastScene = RandomScene;
   
            }
           
        }

    }
}
