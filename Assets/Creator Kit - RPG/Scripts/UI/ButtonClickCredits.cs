using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClickCredits : MonoBehaviour
{

    public Button volver;
    // Start is called before the first frame update
    void Start()
    {
        Button back = volver.GetComponent<Button>();
        back.onClick.AddListener(TaskOnClickBack);
    }

    void TaskOnClickBack()
    {
        SceneManager.LoadScene("Inicio");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
