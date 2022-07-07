using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Menu : MonoBehaviour
{
    public TextMeshProUGUI[] datosText;
    public Item[] objDatos; 
    public Image itemImage;
    // Start is called before the first frame update
    void Start()
    {
         AsignaUnoaVarios(objDatos[1]);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AsignaUnoaVarios(Item objDatos){
     for (int i = 0; i < datosText.Length; i++)
        {
            datosText[i].text=objDatos.GetDatos(i);
            this.itemImage.sprite=objDatos.itemImage;
        }
    }
}
