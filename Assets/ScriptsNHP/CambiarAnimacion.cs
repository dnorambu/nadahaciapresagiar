using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPGM.Gameplay;

public class CambiarAnimacion : MonoBehaviour
{
    public Quest questFinal = null;

    public AnimatorOverrideController animNuevo = null;
    bool isChanged = false;
    Animator anim; 
    // Update is called once per frame
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        if(questFinal != null && !isChanged)
        {
            if (questFinal.isStarted)
            {
                Debug.Log("Si esta entrando aqui");
                isChanged = true;
                anim.runtimeAnimatorController = animNuevo;
            }
        }
    }
}
