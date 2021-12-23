using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TiroDeGracia : MonoBehaviour
{
    public string Escena = "";
    public int tiempo = 2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("He iniciado la vida en este juego");
        StartCoroutine(Corutina());
    }
    
    IEnumerator Corutina()
    {
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(tiempo);
        SceneManager.LoadScene(Escena);
        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
}
