using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorM : MonoBehaviour
{
    public float Velocidad = 5f;
    public Rigidbody2D rb2D;
    // Start is called before the first frame update

    void Awake()
    {
        rb2D = gameObject.AddComponent<Rigidbody2D>();
    }
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

        if(Input.GetKey(KeyCode.S))
        {
            rb2D.AddForce(transform.up*Velocidad);
        }
    }
}
