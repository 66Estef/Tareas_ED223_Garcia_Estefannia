using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nuevo item")]

public class Item : ScriptableObject
{
    public string Nombre;
    public string Edad;
    public string Sexo;
    public string Descripción;
    public string[]Informacion;
    // Start is called before the first frame update
    void OnEnable()
    {
        Informacion = new string[]{Nombre, Edad, Sexo, Descripción};
    }

    // Update is called once per frame
    public string GetDatos(int Indice)
    {
        return Informacion[Indice];
    }
}
