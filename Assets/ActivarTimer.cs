using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RPGM.Gameplay;
public class ActivarTimer : MonoBehaviour
{
    // Start is called before the first frame update
    public Quest mision;
    public Transform player;
    public Reloj reloj;
    public Text texto;
    float distance;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
        distance = Vector2.Distance(player.position, this.transform.position);
        print(distance);

        if (distance <= 1f)
        {
            if (reloj.estarPausado)
            {
                print("Se ve el timer");
                VerTimer();
            }
        }
    }

    void VerTimer()
    {
        texto.color = new Color(texto.color.r, texto.color.g, texto.color.b, 1f);
        reloj.ReiniciarReloj();
    }

}
