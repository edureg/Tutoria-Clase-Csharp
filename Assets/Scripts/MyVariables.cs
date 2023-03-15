using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyVariables : MonoBehaviour
{
    int saludPersonaje = 100;

    const int deterioroSalud = 10;

    float velocidadPersonaje = 14.74f;

    const float gravedadPlaneta = 7.44f;

    string mensajeBienvenida = "Bienvenido a este Gran Juego. ";

    const string mensajeIniciarPartida = "Da Click para Iniciar";

    bool partidaIniciada = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Salud Inicial: " + saludPersonaje);
        Debug.Log("Daño que recibe: " + deterioroSalud);
        Debug.Log("Velocidad del personaje: " + velocidadPersonaje + " km/h");
        Debug.Log("La Aceleracion Gravitacional: " + gravedadPlaneta + " m/s^2");
        Debug.Log(mensajeBienvenida + mensajeIniciarPartida);
        Debug.Log("Partida Iniciada: " + partidaIniciada);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
