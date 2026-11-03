using UnityEngine;
using UnityEngine.UIElements;

public class Damage : MonoBehaviour
{
    PlayerHealth playerHealth;

    public int damage = 20;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<PlayerMouvement>())
        {
            
            playerHealth.TakeDamage(damage);
            other.transform.position = new Vector3(0.17f, 0.95f, -14.41f);
            Destroy(gameObject);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerHealth = FindFirstObjectByType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


