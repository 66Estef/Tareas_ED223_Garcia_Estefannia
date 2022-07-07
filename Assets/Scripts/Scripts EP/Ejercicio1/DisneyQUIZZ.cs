using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NuevaPregunta")]
public class DisneyQUIZZ : ScriptableObject 
{
    public string Pregunta;
    public string[]Opciones;
    public int RespuestaCorrecta;
}
