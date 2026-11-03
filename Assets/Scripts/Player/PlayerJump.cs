using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponentInParent<Jump>())
        {
            Debug.Log("jump");
            rb.AddForce(Vector3.up * 10f, ForceMode.Impulse);
        }
    }
}
    