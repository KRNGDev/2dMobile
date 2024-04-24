using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AtaqueEnemigo : MonoBehaviour
{
    public string tagPlayer = "Player";
    public int danyo = 1;
    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.transform.CompareTag(tagPlayer)){
            Destroy(gameObject);
            GameObject.Find("GameManager")?.GetComponent<GameManager>().HacerDanyo(danyo);
        }
    }
}
