using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Quizz : MonoBehaviour
{
    public BuildQuizz[] objQuizz;

    public int indice;
    public TextMeshProUGUI pregunta;
    public TextMeshProUGUI[] respuestasText; 
    // Start is called before the first frame update
    void Start()
    {
        indice= Random.Range(0,objQuizz.Length);
          pregunta.text = objQuizz[indice].Getpregunta();

        for (int i = 0; i < respuestasText.Length; i++)
        {
            respuestasText[i].text= objQuizz[indice].GetRespuestas(i);
        }


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
           /* indice++;
            if(indice > objQuizz.Length){
                indice=0;
            }*/
           indice= Random.Range(0,objQuizz.Length);
        }
        

        pregunta.text = objQuizz[indice].Getpregunta();

        for (int i = 0; i < respuestasText.Length; i++)
        {
            respuestasText[i].text= objQuizz[indice].GetRespuestas(i);
        }
    }
}
