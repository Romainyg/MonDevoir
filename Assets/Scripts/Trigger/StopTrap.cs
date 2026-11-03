using Unity.VisualScripting;
using UnityEngine;

public class StopTrap : MonoBehaviour
{
    [SerializeField] private SpawneTrap[] spawneTrap;
    [SerializeField] private GameObject[] translate;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.GetComponent<PlayerMouvement>())
        {
            for (int i = 0; i < spawneTrap.Length; i++)
            {
                spawneTrap[i].isTrapActive = false;
            }
            DestroyAll();
        }
    }
    private void DestroyAll()
    {
        Translate[] objets = FindObjectsByType<Translate>(FindObjectsSortMode.None);

        foreach (Translate objet in objets)
        {
            Destroy(objet.gameObject);
        }
    }
}
