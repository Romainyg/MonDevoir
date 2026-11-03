using UnityEngine;
using UnityEngine.SceneManagement;

public class TutoMenu : MonoBehaviour
{
public void back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
