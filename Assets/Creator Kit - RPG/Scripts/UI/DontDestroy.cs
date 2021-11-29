using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("Music");

        if(musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);

        if(SceneManager.GetActiveScene().name == "Prologo"){
            Destroy(this.gameObject);
        }

    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Prologo")
        {
            Destroy(this.gameObject);
        }
    }
}

