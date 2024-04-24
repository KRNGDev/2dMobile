using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovedorPlayer : MonoBehaviour
{
    public Joystick joystick;
    public float velocidadDesplazamiento;
    public float velocidadSalto;
    public AudioClip sonidoSalto;
    [Header("Marcar si se desea utilizar el pad analógico de XBOX en lugar del digital")]
    public bool padAnalogicoXBOX = false;

    private float horizontal;

    private Rigidbody2D playerRB2D;
    void Start()
    {
        print(Application.platform);
        playerRB2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            horizontal = joystick.Horizontal;
        }
        else
        {
            horizontal = Input.GetAxis("Horizontal");
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Jump"))
            {
                Saltar();
            }
        }
        playerRB2D.velocity =
                new Vector2(horizontal * velocidadDesplazamiento, playerRB2D.velocity.y);
        if (padAnalogicoXBOX)
        {
            horizontal = Input.GetAxis("HorizontalXBox");
        }
    }

    public void Saltar()
    {
        if (Math.Abs(playerRB2D.velocity.y) < 0.01f)
        {
            playerRB2D.velocity =
                new Vector2(horizontal * velocidadDesplazamiento, velocidadSalto);
            AudioSource.PlayClipAtPoint(sonidoSalto, playerRB2D.position);
        }
    }
}
