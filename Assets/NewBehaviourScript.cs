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
        texto.tex = "Caricatura favorita";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.1))
        {
            texto.text = "Yo iré solo por que soy BÁRBARO";
        }
        if(Input.GetKeyDown(KeyCode.H))
        {
            texto.text = "Apártate cabeza de balón";
        }
        if(Input.GetKeyDown(KeyCode.B))
        {
            texto.text = "¡Y así nacieron las chicas superrrrrrpoderosas";
        }
        if(Input.GetKeyDown(KeyCode.P))
        {
            texto.text = "Ferb, ¡ya se que vamos a hacer hoy!";
        }
    }
}
