using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPGM.Gameplay;



public class StoryDED : MonoBehaviour
{

    public Quest lacuest;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lacuest.isFinished)
        {
            Destroy(gameObject);
        }
    }
}
