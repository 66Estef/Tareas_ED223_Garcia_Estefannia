using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproductor : MonoBehaviour
{
    [SerializeField]
    AudioSource audioS; // Hace referencia a el componente que quiere manipular
    public AudioClip[] ListaAudio; // crea un arreglo de clips de audio
    public int indice=0; //un valor mutable para recorrer el arreglo

    // Start is called before the first frame update
    void Start()
    {
        audioS = GetComponent<AudioSource>(); // Enlaza o lee el componente AudioSource en el objeto
        //dueño de este script
        //ListaAudio= new AudioClip[3];

        audioS.clip = ListaAudio[indice]; //asigna desde la lista el valor inicial que a reproducir
        //el audiosource
        audioS.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))//Asigno una tecla
        {
           AumentarIndice();

        }

         if (Input.GetKeyDown(KeyCode.B))//Asigno una tecla
        {
           DisminuirIndice();

        }
        
        audioS.clip = ListaAudio[indice];//Actualiza el valor del clip asignado a el audiosource
       
        if (!audioS.isPlaying) // comprueba si actuamente no se esta reproduciendo el audioSource
            // si comprueba que no hay reproducción entonces manda a darle play
            audioS.Play();//refresca la reproducción del audio source

    }// fin Update



// Aqui inician metodos o funciones
   public void AumentarIndice(){
       
      indice++;//Aumento al indice
            if (indice >= ListaAudio.Length)//comparo el valor de indice con la cantidad de elementos
            {
                Debug.Log("ya llegaste a la meta");
                indice= ListaAudio.Length-1;//asigno a indice el ultimo valor conocido en la lista
            
        }
        
      
    }

   public void DisminuirIndice(){
     
       indice--;//Aumento al indice
            if (indice <= 0)//comparo el valor de indice con la cantidad de elementos
            {
                Debug.Log("ya regresaste");
                indice= 0;//asigno a indice el ultimo valor conocido en la lista
           
        }
        audioS.Play();
    }



}// fin de clase
