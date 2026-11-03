using UnityEngine;

public class Translate : MonoBehaviour
{
    [SerializeField] int speed = 5;

    GameManager gameManager;

    bool end = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (end == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        
    }


}
