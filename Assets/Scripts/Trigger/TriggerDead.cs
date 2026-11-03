using UnityEngine;

public class TriggerDead : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

        if (other.gameObject.GetComponent<PlayerMouvement>())
        {
            Debug.Log("DamgeLave");
            playerHealth.TakeDamage(10);
            other.transform.position = new Vector3(-0.11f, 1.15f, -7.01f);
            
        }
    }

}
