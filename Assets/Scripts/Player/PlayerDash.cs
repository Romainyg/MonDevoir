using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    public Rigidbody rb;
    public float dashForce = 10f;
    public int maxNumberOfDashes = 1;
    [SerializeField] GameObject DashUI;
    [SerializeField] private GameManager gameManager;
    [SerializeField] private AudioSource audioSource;

    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Dash();
        }
        if (gameManager.numberOfDashes >= 1)
        {
            DashUI.SetActive(true);
        }
        else
        {
            DashUI.SetActive(false);
        }
    }

    void Dash()
    {
        if (gameManager.numberOfDashes > 0)
        {
            Vector3 direction = new Vector3
            (Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical")).normalized;

            if (direction.magnitude > 0)
            {
                rb.AddForce(direction * dashForce, ForceMode.Impulse);
            }
            gameManager.numberOfDashes--;
            DashUI.SetActive(false);
            audioSource.Play();
        }

    }

}

