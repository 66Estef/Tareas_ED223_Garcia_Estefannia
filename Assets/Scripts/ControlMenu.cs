using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlMenu : MonoBehaviour
{
    public Canvas menuCanvas;

    public bool abrirCerrar;
    // Start is called before the first frame update
    void Start()
    {
        menuCanvas.enabled= abrirCerrar;
    }

    // Update is called once per frame
    void Update()
    {

     if(Input.GetKeyDown(KeyCode.Escape)){
        OpenClose();
     }
      menuCanvas.enabled= abrirCerrar;
    }

    void OpenClose(){

        abrirCerrar = !abrirCerrar;

    }
}
