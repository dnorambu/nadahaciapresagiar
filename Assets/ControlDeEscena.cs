using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using RPGM.Gameplay;
using System.Threading;
public class ControlDeEscena : MonoBehaviour
{
    // Start is called before the first frame update
    public Quest mision;
    public bool AntiLoop = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mision.isFinished && AntiLoop)
        {
            StartCoroutine(ExampleCoroutine());
            AntiLoop = false;
        }
    }
    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(3);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        SceneManager.LoadScene("Prologo");
    }
}
