using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPGM.Core;
using RPGM.Gameplay;

public class Revelar : MonoBehaviour
{
    private bool fadeOut, fadeIn;
    public Transform player;
    public SpriteRenderer OtraParte = null;
    public float fadeSpeed = 0.8f;
    float distance;
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
            distance = Vector3.Distance(player.position, this.transform.position);
            //print(distance);
            //print(OtraParte.color.r);
            if (distance <= 1f){
                fadeOutObject();
            }
        }
        
        if (fadeOut)
        {
            Color objectColor = this.GetComponent<SpriteRenderer>().color;
            float fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);
            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            this.GetComponent<SpriteRenderer>().color = objectColor;
            if (OtraParte != null)
            {
                Color objectColor2 = OtraParte.color;
                float fadeAmount2 = objectColor2.a - (fadeSpeed * Time.deltaTime);
                objectColor2 = new Color(objectColor2.r, objectColor2.g, objectColor2.b, fadeAmount2);
                OtraParte.color = objectColor2;
            }
            if (objectColor.a < 0.3 || !Input.GetKey(KeyCode.Q) )
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

            if( OtraParte != null)
            {
                Color objectColor2 = OtraParte.color;
                float fadeAmount2 = objectColor2.a + (fadeSpeed * Time.deltaTime);

                objectColor2 = new Color(objectColor2.r, objectColor2.g, objectColor2.b, fadeAmount2);
                OtraParte.color = objectColor2;
            }

            if (objectColor.a > 1)
            {
                fadeIn = false;
            }
        }
    }


}
