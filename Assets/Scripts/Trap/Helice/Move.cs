using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] int speed = 2;

    bool right = true;

    private void Start()
    {

    }
    
    void Update()
    {
        if (right == true)
        {
            TranslateRight();
        }
        else if (right == false)
        {
            TranslateLeft();
        }
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Wall>())
        {
            right = !right;
        }
 
    }

    void TranslateRight ()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void TranslateLeft()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

}
