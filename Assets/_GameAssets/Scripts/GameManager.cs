using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI textNumeroMonedas;

    public GameObject joystickVirtual;
    public GameObject botonVirtualA;
    public GameObject botonVirtualB;

    public Image imageSalud;

    public int saludMaxima = 100;
    public int salud;

    private int numeroMonedas = 0;

    void Start(){
        salud = saludMaxima;
        if (Application.platform != RuntimePlatform.Android) 
        {
            joystickVirtual?.SetActive(false);
            botonVirtualA?.SetActive(false);
            botonVirtualB?.SetActive(false);
        } else {
            joystickVirtual?.SetActive(true);
            botonVirtualA?.SetActive(true);
            botonVirtualB?.SetActive(true);
        }
    }

    public void AddCoin()
    {
        numeroMonedas++;

        if (textNumeroMonedas == null)
        {
            Debug.LogError("El GameManager no est� correctamente configurado");
        } else
        {
            textNumeroMonedas.text = numeroMonedas.ToString();
        }
    }

    public void HacerDanyo(int danyo){
        salud = salud - danyo;
        
        //Si es 0 o menos, ¿Qué hacemos?
        print("TODO: programar fin de la vida");

        //Reducir la visibilidad de la imagen de la salud
        imageSalud.fillAmount = (float)salud/(float)saludMaxima;
    }
}
