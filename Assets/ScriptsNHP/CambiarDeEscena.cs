using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using RPGM.Gameplay;


public class CambiarDeEscena : MonoBehaviour

{
    public Quest quest = null;
    public GameObject roof1;
    public GameObject roof2;
    public string escena = "Nivel";
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Destroy(roof1);
        //Destroy(roof2);
        //Debug.Log("Ha colisionado!");

        if (quest.isFinished)
        {
        SceneManager.LoadScene(escena);
        }
    }
}
