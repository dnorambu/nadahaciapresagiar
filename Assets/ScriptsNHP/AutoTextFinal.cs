using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AutoTextFinal : MonoBehaviour
{
    public float letterPause = 0.1f;
    public string[] sentences;
    public string Escena = "";
    int pos = 0;
    string message;
    public Text textComp;
    public Text textHint;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Corutina());
    }

    IEnumerator TypeText(string mensaje)
    {
        foreach (char letter in mensaje.ToCharArray())
        {
            textComp.text += letter;
            yield return new WaitForSeconds(letterPause);
        }
        textHint.text = "Presione 'Espacio' para avanzar.";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))

        {
            if (textComp.text == sentences[pos])
            {
                if (sentences.Length == pos + 1)
                {
                    LoadScene(Escena);
                }
                else
                {
                    textComp.text = "";
                    pos += 1;
                    textHint.text = "";
                    StartCoroutine(TypeText(sentences[pos]));
                }

            }
            else
            {
                StopAllCoroutines();
                textComp.text = sentences[pos];
                textHint.text = "Presione 'Espacio' para avanzar.";
            }
        }

    }
    IEnumerator Corutina()
    {
        //Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(3);
        textComp = GetComponent<Text>();
        message = textComp.text;
        textComp.text = "";
        StartCoroutine(TypeText(sentences[pos]));
        //After we have waited 5 seconds print the time again.
        //Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }

    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
