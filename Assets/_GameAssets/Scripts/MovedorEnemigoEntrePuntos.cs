using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovedorEnemigoEntrePuntos : MonoBehaviour
{
    public Transform punto1;
    public Transform punto2;
    
    public float speed = 0.05f;
    private float factorInterpolacion = 0;


    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        StartCoroutine(Move());
    }

    IEnumerator Move()
    {
        while (true)
        {
            if (factorInterpolacion >= 1)
            {
                factorInterpolacion = 1;
                speed = -speed;
                spriteRenderer.flipX=!spriteRenderer.flipX;
            }
            else if (factorInterpolacion <= 0)
            {
                factorInterpolacion = 0;
                speed = -speed;
                spriteRenderer.flipX=!spriteRenderer.flipX;
            }
            factorInterpolacion += speed;
            transform.position = Vector3.Lerp(punto1.position, punto2.position, factorInterpolacion);
            yield return new WaitForSeconds(.016f);
        }
    }
}
