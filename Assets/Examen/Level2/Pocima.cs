using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Pocima : MonoBehaviour
{
     public Image imagenPocima;
     public TextMeshProUGUI text;

     public ConstItem item;

    // Start is called before the first frame update
    void Start()
    {
        imagenPocima.sprite = item.imagenItem;
    }

    
    public void ItemSelecionado()
    {
        
        text.text = item.GetSeleccion("Seleccionaste la pocima: " + gameObject.name);
        imagenPocima.gameObject.SetActive(false);
    }

    public void ActivarItem()
    {
        
    
        imagenPocima.gameObject.SetActive(true);
    }
}
