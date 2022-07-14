using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorM : MonoBehaviour
{
    public float Velocidad = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right *Velocidad*Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.I))
        {
            transform.position += Vector3.left *Velocidad*Time.deltaTime;
        }
    }
}
