using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPGM.Gameplay;

public class MoverGuardia : MonoBehaviour
{
    // Start is called before the first frame update
    public Quest mision;
    private bool yaSeMovio = false;
    private NPCController dialogo;
    private ConversationScript ConvScr;
    // Update is called once per frame
    private void Start()
    {
        dialogo = GetComponent<NPCController>();
        ConvScr = GetComponent<ConversationScript>();
    }
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
        ConvScr.Set(ConvScr.items[0], ConvScr.items[1]);
    }
}
