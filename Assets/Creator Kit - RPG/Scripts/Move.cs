using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float velocidad = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * velocidad* Time.deltaTime; 
        }
         

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * velocidad* Time.deltaTime; 
        }

        if (Input.GetKey(KeyCode.UpArrow)){
            transform.position += Vector3.up * velocidad* Time.deltaTime; 
        }

        if (Input.GetKey(KeyCode.DownArrow)){
            transform.position += Vector3.down * velocidad* Time.deltaTime; 
        }
    }
    
    
}
