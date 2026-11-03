using System;
using UnityEngine;

public class Dash : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<Collider>().enabled = false;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(gameManager.numberOfDashes != gameManager.maxNumberOfDashes)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            gameObject.GetComponent<Collider>().enabled = true;
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<Collider>().enabled = false;
        }
    }

}
