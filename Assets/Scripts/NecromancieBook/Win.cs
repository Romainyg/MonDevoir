using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<PlayerMouvement>())
        {
            SceneManager.LoadScene("VitoryMenu");
        }
    }
}
