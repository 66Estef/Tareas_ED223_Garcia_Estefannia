using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI texto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.V1))
        {
            texto.text = "Yo iré solo por que soy BÁRBARO";
        }
        if(Input.GetKeyDown(KeyCode.V2))
        {
            texto.text = "Apártate cabeza de balón";
        }
        if(Input.GetKeyDown(KeyCode.V))
        {
            texto.text = "¡Y así nacieron las chicas superrrrrrpoderosas";
        }
        if(Input.GetKeyDown(KeyCode.V3))
        {
            texto.text = "Ferb, ¡ya se que vamos a hacer hoy!";
        }
    }
}
