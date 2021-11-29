using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Reloj : MonoBehaviour
{
    // Start is called before the first frame update
    [Tooltip("Tiempo inicial en segundos")]
    public int tiempoInicial;

    [Tooltip("Escala de tiempo del reloj")]
    [Range(-10.0f, 10.0f)]
    public float escalaDeTiempo = 1;
    public Transform player;
    private Text texto;
    private float tiempoDelFrameConTimeScale = 0f;
    private float tiempoAmostrarEnSegundos = 0f;
    private float escaladeTiempoAlPausar, escalaDeTiempoinicial;
    public bool estarPausado = true;

    private void Start()
    {
        escalaDeTiempoinicial = escalaDeTiempo;
        texto = GetComponent<Text>();
        tiempoAmostrarEnSegundos = tiempoInicial;
        ActualizarReloj(tiempoInicial);
    }

    public void ActualizarReloj(float tiempoEnSegundos)
    {
        int minutos, segundos;
        string textoDelReloj;

        if (tiempoEnSegundos < 0)
        {
            texto.color = new Color(texto.color.r, texto.color.g, texto.color.b, 0f);
            tiempoEnSegundos = tiempoInicial;
            //tepea
            player.position = new Vector2(19.53f, 2.5f);
            Pausar();
        }
        minutos = (int)tiempoEnSegundos / 60;
        segundos = (int)tiempoEnSegundos % 60;
        textoDelReloj = minutos.ToString("00") + ":" + segundos.ToString("00");
        texto.text = textoDelReloj;
    } 
    public void Update()
    {
        if (!estarPausado)
        {
            tiempoDelFrameConTimeScale = Time.deltaTime * escalaDeTiempo;
            tiempoAmostrarEnSegundos -= tiempoDelFrameConTimeScale;
            ActualizarReloj(tiempoAmostrarEnSegundos);
        }
    }

    public void Pausar()
    {
        if (!estarPausado)
        {
            estarPausado = true;
            escaladeTiempoAlPausar = escalaDeTiempo;
            escalaDeTiempo = 0;
        }
    }

    public void Continuar()
    {
        if (estarPausado)
        {
            estarPausado = false;
            escalaDeTiempo = escaladeTiempoAlPausar;
        }
    }

    public void ReiniciarReloj()
    {
        estarPausado = false;
        escalaDeTiempo = escalaDeTiempoinicial;
        tiempoAmostrarEnSegundos = tiempoInicial;
        ActualizarReloj(tiempoAmostrarEnSegundos);
    }
}
