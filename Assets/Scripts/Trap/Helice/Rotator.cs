using UnityEngine;

public class Rotator : MonoBehaviour
{
    float rotator = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, rotator + 1.5f);
    }
}
