using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClickStart : MonoBehaviour
{
    public Button empezar;
    public Button controles;
    public Button creditos;
    // Start is called before the first frame update
    void Start()
    {
        Button start = empezar.GetComponent<Button>();
        Button controls = controles.GetComponent<Button>();
        Button credits = creditos.GetComponent<Button>();
        start.onClick.AddListener(TaskOnClickStart);
        controls.onClick.AddListener(TaskOnClickControls);
        credits.onClick.AddListener(TaskOnClickCredits);
    }

    void TaskOnClickStart()
    {
        SceneManager.LoadScene("Prologo");
    }
    void TaskOnClickControls()
    {
        SceneManager.LoadScene("Controles");
    }
    void TaskOnClickCredits()
    {
        SceneManager.LoadScene("Creditos");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
