using UnityEngine;

public class SpawneTrap : MonoBehaviour
{
    public bool isTrapActive = false;
    [SerializeField] private GameObject trap;
    [SerializeField] private float timer = 0;
    [SerializeField] private bool reload = true;

    [SerializeField] int Cooldown = 120;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += 0.2f;
        if (timer >= Cooldown)
        {
            if (isTrapActive == true)
            {
                SpawnTrap();
                reload = true;
            }

        }
    }

    public void SpawnTrap()
    {
        if(isTrapActive == true)
        {  
            if(reload == true)
            {
               
                reload = false;
                Vector3 position = transform.position + new Vector3(5, 0, 5);
                Instantiate(trap, position, transform.rotation);
                timer = 0;
            }

            
        }
    }
}
