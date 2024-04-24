using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muelle : MonoBehaviour
{
    public string tagPlayer = "Player";
    public float fuerza = 15;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {


        {
            if (other.gameObject.CompareTag(tagPlayer))
            {
                // Impulsar al PLAyer hacia arriba
                other.transform.GetComponent<Rigidbody2D>().velocity = Vector2.up * fuerza;
                animator.SetBool("abierto", true);

            }
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        animator.SetBool("abierto", false);
    }
}

