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
        if(Input.GetKeyDown(KeyCode.M))
        {
            texto.text="Yo iré solo porque soy BÁRBARO";
        }
        if(Input.GetKeyDown(KeyCode.H))
        {
            texto.text="¡Apártate cabeza de balón!";
        }
        if(Input.GetKeyDown(KeyCode.B))
        {
            texto.text="Y así nacieron las chicas superrrrrrpoderosas:Bombón, Burrrbuja y Bellota";
        }
        if(Input.GetKeyDown(KeyCode.P))
        {
            texto.text="Ferb,¡ya se que vamos a hacer hoy!";
        }
    }
}// fin del cuerpo de class
