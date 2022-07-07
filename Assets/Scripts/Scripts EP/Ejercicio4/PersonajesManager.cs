using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajesManager : MonoBehaviour
{
    public static PersonajesManager Instance;
    public List<Item> Personajes;
    // Start is called before the first frame update
    private void Awake()
    {
        if(PersonajesManager.Instance == null)
        {
            PersonajesManager.Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
