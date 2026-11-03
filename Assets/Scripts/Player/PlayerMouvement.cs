using UnityEngine;

public class PlayerMouvement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed = 5f;

    float HorizontalVelocity = 0f;

    float VerticalVelocity = 0f;

    bool onIce = false;

    public float iceAcceleration = 3f;

    public float iceDeceleration = 0.5f;

    float changeSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ice"))
        {
            onIce = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ice"))
        {
            onIce = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            HorizontalVelocity = 1f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            HorizontalVelocity = -1f;
        }
        else
        {
            HorizontalVelocity = 0f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            VerticalVelocity = 1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            VerticalVelocity = -1f;
        }
        else
        {
            VerticalVelocity = 0f;
        }

        if (onIce == true)
        {
            if (HorizontalVelocity != 0)
            {
                changeSpeed = iceAcceleration;
                GetComponent<Rigidbody>().linearVelocity = new Vector3(HorizontalVelocity * speed * changeSpeed, rb.linearVelocity.y, VerticalVelocity * speed * changeSpeed);
            }
            else
            {
                changeSpeed = iceDeceleration;
                GetComponent<Rigidbody>().linearVelocity = new Vector3(rb.linearVelocity.x * changeSpeed, rb.linearVelocity.y, changeSpeed * rb.linearVelocity.z);
            }

            if (VerticalVelocity != 0)
            {
                changeSpeed = iceAcceleration;
                GetComponent<Rigidbody>().linearVelocity = new Vector3(HorizontalVelocity * speed * changeSpeed, rb.linearVelocity.y, VerticalVelocity * speed * changeSpeed);
            }
            else
            {
                changeSpeed = iceDeceleration;
                GetComponent<Rigidbody>().linearVelocity = new Vector3(rb.linearVelocity.x * changeSpeed, rb.linearVelocity.y, changeSpeed * rb.linearVelocity.z);
            }


        }
        else
        {
            GetComponent<Rigidbody>().linearVelocity = new Vector3(HorizontalVelocity * speed, rb.linearVelocity.y, VerticalVelocity * speed);
        }
        
    }
}
