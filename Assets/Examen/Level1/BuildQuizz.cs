using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BuildQuizz : ScriptableObject
{
    public string pregunta;
    public string[] respuestas;
    public int respuestaCorrecta; 
    


    public string Getpregunta(){
        
        return pregunta;
    }
    public string GetRespuestas(int index){
        
        return respuestas[index];
    }
}
