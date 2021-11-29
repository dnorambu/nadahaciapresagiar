using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPGM.Gameplay;

public class MoverGuardia : MonoBehaviour
{
    // Start is called before the first frame update
    public Quest mision;
    private bool yaSeMovio = false;

    // Update is called once per frame
    void Update()
    {
        if (mision.isStarted)
        {
            if (!yaSeMovio)
            {
                ActualizarPos();
            }
        }
    }
    
    void ActualizarPos()
    {
        this.transform.position = new Vector2(22f, 2.20f);
        yaSeMovio = true;
    }
}
