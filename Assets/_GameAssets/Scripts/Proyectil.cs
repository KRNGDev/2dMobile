using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public string tagPlayer;
    public string tagEnemigo;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(tagEnemigo))
        {
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);
    }
}
