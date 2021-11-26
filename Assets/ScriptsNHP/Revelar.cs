using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPGM.Core;
using RPGM.Gameplay;

public class Revelar : MonoBehaviour
{
    private bool fadeOut, fadeIn;
    public float fadeSpeed;

    public void fadeOutObject()
    {
        fadeOut = true;
        fadeIn = false;
    }

    public void fadeInObject()
    {
        fadeIn = true;
        fadeOut = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            fadeOutObject();
        }
        
        if (fadeOut)
        {
            Color objectColor = this.GetComponent<SpriteRenderer>().color;
            float fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            this.GetComponent<SpriteRenderer>().color = objectColor;

            if (objectColor.a < 0.3 || !Input.GetKey(KeyCode.Q))
            {
                fadeInObject();
            }
        }
        if (fadeIn)
        {
            Color objectColor = this.GetComponent<SpriteRenderer>().color;
            float fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            this.GetComponent<SpriteRenderer>().color = objectColor;

            if (objectColor.a > 1)
            {
                fadeIn = false;
            }
        }
    }


}
