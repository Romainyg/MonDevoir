using UnityEngine;

public class ZoneAttack : MonoBehaviour
{
    public float speed = 5f;
    public float maxSize = 15f;

    void Update()
    {
        transform.localScale += Vector3.one * speed * Time.deltaTime;

        if (transform.localScale.x >= maxSize)
        {
            Destroy(gameObject);
        }
    }
}
