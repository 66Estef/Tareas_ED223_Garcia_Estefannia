using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName ="nuevo item")]
public class ConstItem : ScriptableObject
{
    public Sprite imagenItem;

  public string GetSeleccion(string mensaje){
      return mensaje;
  }

}
