using UnityEngine;

public class TrapLight : MonoBehaviour
{
    bool isTrapActive = false;
    bool ChangeColor = false;
    [SerializeField] private float timer = 0;
    [SerializeField] private float SecurTimer = 0;

    float reload;

    int mouve;



    [SerializeField] private PlayerHealth playerHealth;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Light>().color = Color.green;
        reload = Random.Range(10f, 20f);
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            mouve = 1;
        }
        else
        {
            mouve = 0;
        }
        
        if(mouve >= 1 && isTrapActive == true)
        {
            playerHealth.TakeDamage(10);
            GetComponent<Light>().color = Color.green;
            isTrapActive = false;
            reload = Random.Range(10f, 20f);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(timer >= reload)
        {
            changeColor();
            timer = 0;
        }
        else
        {
            timer += 0.2f;

        }
        if (ChangeColor == true && isTrapActive == false)
        {
            SecurTimer += 0.2f;

            if (SecurTimer >= 5f)
            {
                isTrapActive = true;
                ChangeColor = false;
                SecurTimer = 0;
            }
        }
    }

    void changeColor()
    {
        if (isTrapActive == false)
        {
            GetComponent<Light>().color = Color.red;
            ChangeColor = true;
            SecurTimer = 0;
            if (SecurTimer >= 5f)
            {
                isTrapActive = true;
                reload = Random.Range(10f, 20f);
            }
        }
        else
        {
            ChangeColor = false;
            GetComponent<Light>().color = Color.green;
            isTrapActive = false;
            reload = Random.Range(10f, 20f);
            SecurTimer = 0;
        }

    }
}
