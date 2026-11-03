using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    float speed = 1f;
    bool openDoor = false;

    bool nombreTarget;
    bool nombreRareTarget;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<StopOpenDoor>())
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (openDoor == true)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        
    }

    private void FixedUpdate()
    {
        nombreTarget = FindFirstObjectByType<Target>();
        nombreRareTarget = FindFirstObjectByType<RareTarget>();
        if (nombreTarget == false && nombreRareTarget == false)
        {
            openDoor = true;
            
        }
    }
}
