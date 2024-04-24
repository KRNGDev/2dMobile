using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotadorPlayer : MonoBehaviour
{
    private Rigidbody2D playerRB2D;
    private SpriteRenderer playerSR;
    void Start()
    {
        playerRB2D = GetComponent<Rigidbody2D>();
        playerSR = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (playerRB2D.velocity.x>0){
            playerSR.flipX = false;
        } else if (playerRB2D.velocity.x<0){
            playerSR.flipX = true;
        }
    }
}
