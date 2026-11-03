using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("LevelCamp");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Tuto()
    {
        SceneManager.LoadScene("MenuTuto");

    }
}
