using System;
using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour
{
    [SerializeField] private GameObject Cercle;
    [SerializeField] private Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(AttackLoop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ChoseAttack()
    {
            ItGround();
    }

    void ItGround()
    {
        animator.Play("Scene", 0, 0f);
        Instantiate(Cercle, transform.position, transform.rotation * Quaternion.Euler(90, 0, 0));
    }

    IEnumerator AttackLoop()
    {
        while (true)
        {
            ChoseAttack();

            yield return new WaitForSeconds(5f);
        }
    }
}
