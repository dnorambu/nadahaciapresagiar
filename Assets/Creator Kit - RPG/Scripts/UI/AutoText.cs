using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AutoText : MonoBehaviour
{
    public float letterPause = 0.1f;
    public string[] sentences;
    int pos = 0;
    string message;
    public Text textComp;
    public Text textHint;
    // Start is called before the first frame update
    void Start()
    {
        textComp = GetComponent<Text>();
        message = textComp.text;
        textComp.text = "";
        StartCoroutine(TypeText(sentences[pos]));
    }

    IEnumerator TypeText(string mensaje)
    {
        foreach (char letter in mensaje.ToCharArray())
        {
            textComp.text += letter;
            yield return new WaitForSeconds(letterPause);
        }
        textHint.text = "Presione 'p' para avanzar.";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("p"))
            
        {
            if (textComp.text == sentences[pos])
            {
                if (sentences.Length == pos+1)
                {
                    LoadScene("Nivel");
                } else
                {
                    textComp.text = "";
                    pos += 1;
                    textHint.text = "";
                    StartCoroutine(TypeText(sentences[pos]));
                }
                
            } else
            {
                StopAllCoroutines();
                textComp.text = sentences[pos];
                textHint.text = "Presione 'p' para avanzar.";
            }
        }

    }

    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
