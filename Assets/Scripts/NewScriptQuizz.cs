using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewScriptQuizz : MonoBehaviour
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
            texto.text = "Yo ire solo porque soy BARBARO";
        }

        if(Input.GetKeyDown(KeyCode.H))
        {
            texto.text = "¡Apartate cabeza de balon!";
        }

        if(Input.GetKeyDown(KeyCode.B))
        {
            texto.text = "Y asi nacieron las chicas superrrrpoderosas";
        }

        if(Input.GetKeyDown(KeyCode.P))
        {
            texto.text = "Ferb, ¡¡ya se que vamos a hacer HOY!!";
        }
    }
}
