using System.Collections;
using UnityEngine;

public class MovedorPlataformaEntrePuntos : MonoBehaviour
{
    public Transform punto1;
    public Transform punto2;
    
    public float speed = 0.05f;
    private float factorInterpolacion = 0;

    void Start()
    {
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
            }
            else if (factorInterpolacion <= 0)
            {
                factorInterpolacion = 0;
                speed = -speed;
            }
            factorInterpolacion += speed;
            transform.position = Vector3.Lerp(punto1.position, punto2.position, factorInterpolacion);
            yield return new WaitForSeconds(.016f);
        }
    }
}
