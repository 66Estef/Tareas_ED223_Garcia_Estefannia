using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Click : MonoBehaviour
{
 
 public TextMeshProUGUI textMensaje;
    public Color color1;
   public string mensaje;

   public int indice=0;
  void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        //Destroy(gameObject);
        textMensaje.text = mensaje;
        indice=1;
    }


}
