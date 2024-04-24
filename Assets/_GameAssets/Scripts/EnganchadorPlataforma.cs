using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnganchadorPlataforma : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider2D){
        if (collider2D.transform.gameObject.CompareTag("Plataforma")){
            transform.SetParent(collider2D.transform);
        }
    }
    void OnTriggerExit2D(Collider2D collider2D){
        if (collider2D.transform.gameObject.CompareTag("Plataforma")){
            transform.SetParent(null);
        }
    }
}
