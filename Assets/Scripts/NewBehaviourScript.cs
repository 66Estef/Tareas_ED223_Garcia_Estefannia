using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class NewBehaviourScript : MonoBehaviour
{
   
   //
   public TextMeshProUGUI texto;
   
   //
   public int acelerador;

   public string freno;


    // Start is called before the first frame update
    void Start()
    {
        texto.text="Acelera";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            acelerador++;
            if(acelerador >= 200){
                acelerador=200;
                texto.text = acelerador.ToString();
            }
           
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            texto.text=freno;
        }
         
          //texto.text= acelerador.ToString();
    }
}
