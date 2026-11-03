using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnCamp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerMouvement>())
        {
            SceneManager.LoadScene("LevelCamp");
        }

    }
}
