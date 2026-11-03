using Unity.VisualScripting;
using UnityEngine;

public class ActivateTrap : MonoBehaviour
{
    [SerializeField] private SpawneTrap[] spawneTrap;
    bool canSpawn = true;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger");
        if (other.gameObject.GetComponent<PlayerMouvement>())
        {
            if(canSpawn == true)
            {
                for (int i = 0; i < spawneTrap.Length; i++)
                {
                    canSpawn = false;
                    spawneTrap[i].isTrapActive = true;
                    spawneTrap[i].SpawnTrap();
                }
            }

        }
        if (other.gameObject.GetComponentInParent<Translate>())
        {
            Destroy(other.gameObject);
        }


    }

}
 