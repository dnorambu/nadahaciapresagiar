using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using RPGM.Gameplay;


public class CambiarDeEscena : MonoBehaviour

{
    public Quest quest = null;
    public string escena = "Nivel";
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Ha colisionado!");

        if (quest.isFinished)
        {
            SceneManager.LoadScene(escena);
        }
    }
}
